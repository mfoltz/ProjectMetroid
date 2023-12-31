// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.LegendaryItemGeneratorTemplate
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
  public struct LegendaryItemGeneratorTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StatModsGenerator;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability0ModsGenerator;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability1ModsGenerator;
    [FieldOffset(0)]
    public BlobAssetReference<SpellModSetGeneratorBlob> StatModsGenerator;
    [FieldOffset(8)]
    public BlobAssetReference<SpellModSetGeneratorBlob> Ability0ModsGenerator;
    [FieldOffset(16)]
    public BlobAssetReference<SpellModSetGeneratorBlob> Ability1ModsGenerator;

    static LegendaryItemGeneratorTemplate()
    {
      Il2CppClassPointerStore<LegendaryItemGeneratorTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (LegendaryItemGeneratorTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegendaryItemGeneratorTemplate>.NativeClassPtr);
      LegendaryItemGeneratorTemplate.NativeFieldInfoPtr_StatModsGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemGeneratorTemplate>.NativeClassPtr, nameof (StatModsGenerator));
      LegendaryItemGeneratorTemplate.NativeFieldInfoPtr_Ability0ModsGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemGeneratorTemplate>.NativeClassPtr, nameof (Ability0ModsGenerator));
      LegendaryItemGeneratorTemplate.NativeFieldInfoPtr_Ability1ModsGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemGeneratorTemplate>.NativeClassPtr, nameof (Ability1ModsGenerator));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LegendaryItemGeneratorTemplate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
