// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodItemSource
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodItemSource
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodUnit;
    [FieldOffset(0)]
    public PrefabGUID VBloodUnit;

    static VBloodItemSource()
    {
      Il2CppClassPointerStore<VBloodItemSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodItemSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodItemSource>.NativeClassPtr);
      VBloodItemSource.NativeFieldInfoPtr_VBloodUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodItemSource>.NativeClassPtr, nameof (VBloodUnit));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodItemSource>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
