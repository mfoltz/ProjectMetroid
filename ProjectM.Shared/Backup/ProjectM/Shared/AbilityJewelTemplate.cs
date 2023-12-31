// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.AbilityJewelTemplate
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityJewelTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelItemGenerator;
    [FieldOffset(0)]
    public BlobAssetReference<SpellModSetGeneratorBlob> JewelItemGenerator;

    static AbilityJewelTemplate()
    {
      Il2CppClassPointerStore<AbilityJewelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (AbilityJewelTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityJewelTemplate>.NativeClassPtr);
      AbilityJewelTemplate.NativeFieldInfoPtr_JewelItemGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityJewelTemplate>.NativeClassPtr, nameof (JewelItemGenerator));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityJewelTemplate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
