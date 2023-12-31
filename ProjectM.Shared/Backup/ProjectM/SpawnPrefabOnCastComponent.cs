// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnPrefabOnCastComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SpawnPrefabOnCastComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_Condition;
    private static readonly IntPtr NativeFieldInfoPtr_Target;
    private static readonly IntPtr NativeFieldInfoPtr_HoverDistance;
    private static readonly IntPtr NativeFieldInfoPtr_HoverMaxDistance;
    private static readonly IntPtr NativeFieldInfoPtr_HoverCondition;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnPrefabOnCastComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726941, XrefRangeEnd = 726967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPrefabOnCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726967, XrefRangeEnd = 726985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPrefabOnCastComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726985, XrefRangeEnd = 726986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnPrefabOnCastComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPrefabOnCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnPrefabOnCastComponent()
    {
      Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnPrefabOnCastComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr);
      SpawnPrefabOnCastComponent.NativeFieldInfoPtr_SpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, nameof (SpawnPrefab));
      SpawnPrefabOnCastComponent.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, nameof (Condition));
      SpawnPrefabOnCastComponent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, nameof (Target));
      SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, nameof (HoverDistance));
      SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, nameof (HoverMaxDistance));
      SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, nameof (HoverCondition));
      SpawnPrefabOnCastComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, 100664285);
      SpawnPrefabOnCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, 100664286);
      SpawnPrefabOnCastComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, 100664287);
      SpawnPrefabOnCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPrefabOnCastComponent>.NativeClassPtr, 100664288);
    }

    public SpawnPrefabOnCastComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent SpawnPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_SpawnPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_SpawnPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Condition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_Condition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_Condition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilitySpawnTarget Target
    {
      get
      {
        return *(AbilitySpawnTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_Target));
      }
      [param: In] set
      {
        *(AbilitySpawnTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_Target)) = value;
      }
    }

    public unsafe float HoverDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverDistance)) = value;
      }
    }

    public unsafe float HoverMaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverMaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverMaxDistance)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent HoverCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnPrefabOnCastComponent.NativeFieldInfoPtr_HoverCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
