// Decompiled with JetBrains decompiler
// Type: ProjectM.AimPreviewProjectileCursorNoLine
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AimPreviewProjectileCursorNoLine
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomCircleRadius;
    [FieldOffset(0)]
    public SequenceGUID CircleSequenceGUID;
    [FieldOffset(4)]
    public SequenceState CircleSequenceState;
    [FieldOffset(12)]
    public float CustomCircleRadius;

    static AimPreviewProjectileCursorNoLine()
    {
      Il2CppClassPointerStore<AimPreviewProjectileCursorNoLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimPreviewProjectileCursorNoLine));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimPreviewProjectileCursorNoLine>.NativeClassPtr);
      AimPreviewProjectileCursorNoLine.NativeFieldInfoPtr_CircleSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursorNoLine>.NativeClassPtr, nameof (CircleSequenceGUID));
      AimPreviewProjectileCursorNoLine.NativeFieldInfoPtr_CircleSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursorNoLine>.NativeClassPtr, nameof (CircleSequenceState));
      AimPreviewProjectileCursorNoLine.NativeFieldInfoPtr_CustomCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewProjectileCursorNoLine>.NativeClassPtr, nameof (CustomCircleRadius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AimPreviewProjectileCursorNoLine>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
