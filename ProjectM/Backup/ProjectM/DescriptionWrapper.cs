// Decompiled with JetBrains decompiler
// Type: ProjectM.DescriptionWrapper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.UI;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DescriptionWrapper
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionBuilder;
    [FieldOffset(0)]
    public Entity Prefab;
    [FieldOffset(8)]
    public LocalizedStringBuilderBase DescriptionBuilder;

    static DescriptionWrapper()
    {
      Il2CppClassPointerStore<DescriptionWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DescriptionWrapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptionWrapper>.NativeClassPtr);
      DescriptionWrapper.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptionWrapper>.NativeClassPtr, nameof (Prefab));
      DescriptionWrapper.NativeFieldInfoPtr_DescriptionBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptionWrapper>.NativeClassPtr, nameof (DescriptionBuilder));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DescriptionWrapper>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
