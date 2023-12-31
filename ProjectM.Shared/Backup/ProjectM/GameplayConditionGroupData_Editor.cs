// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayConditionGroupData_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GameplayConditionGroupData_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogicGate;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubGroupsIndexes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditions;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedConditionals;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayConditionGroupData_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayConditionGroupData_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayConditionGroupData_Editor()
    {
      Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayConditionGroupData_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr);
      GameplayConditionGroupData_Editor.NativeFieldInfoPtr_LogicGate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr, nameof (LogicGate));
      GameplayConditionGroupData_Editor.NativeFieldInfoPtr_SubGroupsIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr, nameof (SubGroupsIndexes));
      GameplayConditionGroupData_Editor.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr, nameof (Conditions));
      GameplayConditionGroupData_Editor.NativeFieldInfoPtr_SharedConditionals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr, nameof (SharedConditionals));
      GameplayConditionGroupData_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConditionGroupData_Editor>.NativeClassPtr, 100665946);
    }

    public GameplayConditionGroupData_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConditionalGroupLogicGate LogicGate
    {
      get
      {
        return *(ConditionalGroupLogicGate*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_LogicGate));
      }
      [param: In] set
      {
        *(ConditionalGroupLogicGate*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_LogicGate)) = value;
      }
    }

    public unsafe Il2CppStructArray<int> SubGroupsIndexes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_SubGroupsIndexes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_SubGroupsIndexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameplayConditionComponentData_Editor> Conditions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_Conditions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameplayConditionComponentData_Editor>) null : new Il2CppReferenceArray<GameplayConditionComponentData_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_Conditions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ConditionalSharedAsset> SharedConditionals
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_SharedConditionals));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ConditionalSharedAsset>) null : new Il2CppReferenceArray<ConditionalSharedAsset>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionGroupData_Editor.NativeFieldInfoPtr_SharedConditionals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
