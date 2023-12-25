// Decompiled with JetBrains decompiler
// Type: ProjectM.BurnContainer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BurnContainer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    [FieldOffset(0)]
    public float Progress;
    [FieldOffset(4)]
    public bool Enabled;

    static BurnContainer()
    {
      Il2CppClassPointerStore<BurnContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BurnContainer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr);
      BurnContainer.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, nameof (Progress));
      BurnContainer.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, nameof (Enabled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
