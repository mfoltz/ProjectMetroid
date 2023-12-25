// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilitySpawnPrefabOnStartCast_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class AbilitySpawnPrefabOnStartCast_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideBuffDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;

    static AbilitySpawnPrefabOnStartCast_Editor()
    {
      Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilitySpawnPrefabOnStartCast_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr);
      AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_SpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr, nameof (SpawnPrefab));
      AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_OverrideBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr, nameof (OverrideBuffDuration));
      AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr, nameof (Condition));
    }

    public AbilitySpawnPrefabOnStartCast_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AbilitySpawnPrefabOnStartCast_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast_Editor>.NativeClassPtr, data));
    }

    public unsafe PrefabGuidComponent SpawnPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_SpawnPrefab));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_SpawnPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverrideBuffDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_OverrideBuffDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_OverrideBuffDuration)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Condition
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_Condition));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilitySpawnPrefabOnStartCast_Editor.NativeFieldInfoPtr_Condition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
