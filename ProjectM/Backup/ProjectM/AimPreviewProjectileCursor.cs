// Decompiled with JetBrains decompiler
// Type: ProjectM.AimPreviewProjectileCursor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AimPreviewProjectileCursor
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LineSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomCircleRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowCircle;
    [FieldOffset(0)]
    public SequenceGUID LineSequenceGUID;
    [FieldOffset(4)]
    public SequenceState LineSequenceState;
    [FieldOffset(12)]
    public SequenceGUID CircleSequenceGUID;
    [FieldOffset(16)]
    public SequenceState CircleSequenceState;
    [FieldOffset(24)]
    public float CustomCircleRadius;
    [FieldOffset(28)]
    public bool ShowCircle;

    static AimPreviewProjectileCursor()
    {
      Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimPreviewProjectileCursor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr);
      AimPreviewProjectileCursor.NativeFieldInfoPtr_LineSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, nameof (LineSequenceGUID));
      AimPreviewProjectileCursor.NativeFieldInfoPtr_LineSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, nameof (LineSequenceState));
      AimPreviewProjectileCursor.NativeFieldInfoPtr_CircleSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, nameof (CircleSequenceGUID));
      AimPreviewProjectileCursor.NativeFieldInfoPtr_CircleSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, nameof (CircleSequenceState));
      AimPreviewProjectileCursor.NativeFieldInfoPtr_CustomCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, nameof (CustomCircleRadius));
      AimPreviewProjectileCursor.NativeFieldInfoPtr_ShowCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, nameof (ShowCircle));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AimPreviewProjectileCursor>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
