// Decompiled with JetBrains decompiler
// Type: ProjectM.AimPreviewMelee
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AimPreviewMelee
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConeSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConeSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoxSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoxSequenceState;
    [FieldOffset(0)]
    public SequenceGUID ConeSequenceGUID;
    [FieldOffset(4)]
    public SequenceState ConeSequenceState;
    [FieldOffset(12)]
    public SequenceGUID BoxSequenceGUID;
    [FieldOffset(16)]
    public SequenceState BoxSequenceState;

    static AimPreviewMelee()
    {
      Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimPreviewMelee));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr);
      AimPreviewMelee.NativeFieldInfoPtr_ConeSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr, nameof (ConeSequenceGUID));
      AimPreviewMelee.NativeFieldInfoPtr_ConeSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr, nameof (ConeSequenceState));
      AimPreviewMelee.NativeFieldInfoPtr_BoxSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr, nameof (BoxSequenceGUID));
      AimPreviewMelee.NativeFieldInfoPtr_BoxSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr, nameof (BoxSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AimPreviewMelee>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
