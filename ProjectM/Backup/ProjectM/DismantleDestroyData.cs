// Decompiled with JetBrains decompiler
// Type: ProjectM.DismantleDestroyData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DismantleDestroyData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleDestroyTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleSequenceInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkipDismantleTimeIfReplaced;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasDismantled;
    [FieldOffset(0)]
    public float DismantleDestroyTime;
    [FieldOffset(4)]
    public SequenceState DismantleSequenceInstance;
    [FieldOffset(12)]
    public bool SkipDismantleTimeIfReplaced;
    [FieldOffset(13)]
    public bool WasDismantled;

    static DismantleDestroyData()
    {
      Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DismantleDestroyData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr);
      DismantleDestroyData.NativeFieldInfoPtr_DismantleDestroyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr, nameof (DismantleDestroyTime));
      DismantleDestroyData.NativeFieldInfoPtr_DismantleSequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr, nameof (DismantleSequenceInstance));
      DismantleDestroyData.NativeFieldInfoPtr_SkipDismantleTimeIfReplaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr, nameof (SkipDismantleTimeIfReplaced));
      DismantleDestroyData.NativeFieldInfoPtr_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr, nameof (WasDismantled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DismantleDestroyData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
