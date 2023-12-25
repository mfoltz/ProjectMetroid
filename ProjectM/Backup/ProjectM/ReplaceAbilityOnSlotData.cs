// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReplaceAbilityOnSlotData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyCooldown;
    [FieldOffset(0)]
    public Entity ModificationEntity;
    [FieldOffset(8)]
    public bool CopyCooldown;

    static ReplaceAbilityOnSlotData()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceAbilityOnSlotData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotData>.NativeClassPtr);
      ReplaceAbilityOnSlotData.NativeFieldInfoPtr_ModificationEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotData>.NativeClassPtr, nameof (ModificationEntity));
      ReplaceAbilityOnSlotData.NativeFieldInfoPtr_CopyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotData>.NativeClassPtr, nameof (CopyCooldown));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
