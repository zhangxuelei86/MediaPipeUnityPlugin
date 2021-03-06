using Mediapipe;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetectionGraph : DemoGraph {
  private const string outputDetectionsStream = "output_detections";
  private OutputStreamPoller<List<Detection>> outputDetectionsStreamPoller;
  private DetectionVectorPacket outputDetectionsPacket;

  public override Status StartRun(SidePacket sidePacket) {
    outputDetectionsStreamPoller = graph.AddOutputStreamPoller<List<Detection>>(outputDetectionsStream).ConsumeValue();
    outputDetectionsPacket = new DetectionVectorPacket();

    return graph.StartRun(sidePacket);
  }

  public override void RenderOutput(WebCamScreenController screenController, PixelData pixelData) {
    var detections = FetchNextOutputDetections();
    RenderAnnotation(screenController, detections);

    var texture = screenController.GetScreen();
    texture.SetPixels32(pixelData.Colors);
    texture.Apply();
  }

  private List<Detection> FetchNextOutputDetections() {
    return FetchNextVector<Detection>(outputDetectionsStreamPoller, outputDetectionsPacket, outputDetectionsStream);
  }

  private void RenderAnnotation(WebCamScreenController screenController, List<Detection> detections) {
    // NOTE: input image is flipped
    GetComponent<DetectionListAnnotationController>().Draw(screenController.transform, detections, true);
  }
}
