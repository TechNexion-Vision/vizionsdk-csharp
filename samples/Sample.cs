using VizionSDKSharp;

class Sample
{
    static void Main()
    {
        StringVector devList = new StringVector();
        int cam_num = CSVizionSDK.VxDiscoverCameraDevices(devList);
        Console.WriteLine($"Devices: {cam_num}");

        for (int i = 0; i < devList.Count; i++)
        {
            Console.WriteLine($"[{i}] {devList[i]}");
        }

        VxCamera cam = CSVizionSDK.VxInitialCameraDevice(0);
        int ret = CSVizionSDK.VxOpen(cam);
        Console.WriteLine($"Open camera: {ret}");

        string devName = "";
        ret = CSVizionSDK.VxGetDeviceName(cam, ref devName);
        Console.WriteLine($"GetDeviceName: {ret} / {devName}");

        VX_CAMERA_INTERFACE_TYPE type;
        ret = CSVizionSDK.VxGetDeviceInterfaceType(cam, out type);
        Console.WriteLine($"Get interface type: {ret} / {type}");

        VxFormatVector fmtList = new VxFormatVector();
        ret = CSVizionSDK.VxGetFormatList(cam, fmtList);
        Console.WriteLine($"Get FormatList: {ret}");

        // find mjpg format with min resolution
        int minWidth = 1920;
        int minHeight = 1080;
        VxFormat mjpgFormat = new VxFormat();
        foreach (VxFormat fmt in fmtList)
        {
            if (fmt.format == VX_IMAGE_FORMAT.MJPG && minWidth * minHeight > fmt.width * fmt.height)
            {
                minWidth = fmt.width;
                minHeight = fmt.height;
                mjpgFormat = fmt;
            }
        }

        Console.WriteLine($"{mjpgFormat.format} {mjpgFormat.width}*{mjpgFormat.height} {mjpgFormat.framerate}");

        ret = CSVizionSDK.VxSetFormat(cam, mjpgFormat);
        Console.WriteLine($"Set format: {ret}");

        ret = CSVizionSDK.VxStartStreaming(cam);
        Console.WriteLine($"Start streaming: {ret}");

        long min, max, step, def;
        ret = CSVizionSDK.VxGetUVCImageProcessingRange(cam, VX_UVC_IMAGE_PROPERTIES.UVC_IMAGE_BRIGHTNESS, out min, out max, out step, out def);
        Console.WriteLine($"GetUVCImageProcessingRange: {ret}/{min}/{max}/{step}/{def}");

        ret = CSVizionSDK.VxSetUVCImageProcessing(cam, VX_UVC_IMAGE_PROPERTIES.UVC_IMAGE_BRIGHTNESS, 12, 0);
        Console.WriteLine($"SetUVCImageProcessing: {ret}");

        ret = CSVizionSDK.VxStopStreaming(cam);
        Console.WriteLine($"Stop streaming: {ret}");

        ret = CSVizionSDK.VxClose(cam);
        Console.WriteLine($"Close camera: {ret}");

        devList.Dispose();
    }
}
