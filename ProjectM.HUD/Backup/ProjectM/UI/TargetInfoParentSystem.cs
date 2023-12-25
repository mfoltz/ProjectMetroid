// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TargetInfoParentSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class TargetInfoParentSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetInfoParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__HideHUDBuffQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetUnitQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetUnitQueryMask;
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetStructureQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetStructureQueryMask;
    private static readonly System.IntPtr NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAndUpdatePickedUnit_Private_Data_Entity_Single_Entity_Team_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCustomName_Private_Boolean_Entity_Boolean_byref_FixedString64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAndUpdatePickedStructure_Private_Data_Team_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForValidateAndUpdatePickedUnit_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276173, XrefRangeEnd = 1276242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetInfoParentSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276242, XrefRangeEnd = 1276252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetInfoParentSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276252, XrefRangeEnd = 1276277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetInfoParentSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276449, RefRangeEnd = 1276450, XrefRangeStart = 1276277, XrefRangeEnd = 1276449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TargetInfoParent.Data ValidateAndUpdatePickedUnit(
      Entity pickedUnit,
      float time,
      Entity localPlayer,
      Team localTeam)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pickedUnit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &localTeam;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.NativeMethodInfoPtr_ValidateAndUpdatePickedUnit_Private_Data_Entity_Single_Entity_Team_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new TargetInfoParent.Data(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276450, XrefRangeEnd = 1276472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCustomName(Entity entity, bool isAlly, out FixedString64 result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isAlly;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.NativeMethodInfoPtr_TryGetCustomName_Private_Boolean_Entity_Boolean_byref_FixedString64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276540, RefRangeEnd = 1276541, XrefRangeStart = 1276472, XrefRangeEnd = 1276540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TargetInfoParent.Data ValidateAndUpdatePickedStructure(
      Team localTeam,
      Entity pickedStructure)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pickedStructure;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.NativeMethodInfoPtr_ValidateAndUpdatePickedStructure_Private_Data_Team_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new TargetInfoParent.Data(pointer);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TargetInfoParentSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276541, XrefRangeEnd = 1276577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetInfoParentSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276577, XrefRangeEnd = 1276596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForValidateAndUpdatePickedUnit_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.NativeMethodInfoPtr___GetEntityQuery_ForValidateAndUpdatePickedUnit_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276600, RefRangeEnd = 1276601, XrefRangeStart = 1276596, XrefRangeEnd = 1276600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TargetInfoParentSystem()
    {
      Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TargetInfoParentSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr);
      TargetInfoParentSystem.NativeFieldInfoPtr__TargetInfoParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_TargetInfoParent));
      TargetInfoParentSystem.NativeFieldInfoPtr__HideHUDBuffQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_HideHUDBuffQuery));
      TargetInfoParentSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_GameDataSystem));
      TargetInfoParentSystem.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_UIDataSystem));
      TargetInfoParentSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      TargetInfoParentSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      TargetInfoParentSystem.NativeFieldInfoPtr__TargetUnitQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_TargetUnitQuery));
      TargetInfoParentSystem.NativeFieldInfoPtr__TargetUnitQueryMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_TargetUnitQueryMask));
      TargetInfoParentSystem.NativeFieldInfoPtr__TargetStructureQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_TargetStructureQuery));
      TargetInfoParentSystem.NativeFieldInfoPtr__TargetStructureQueryMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, nameof (_TargetStructureQueryMask));
      TargetInfoParentSystem.NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, "<>ValidateAndUpdatePickedUnit_LambdaJob0_entityQuery");
      TargetInfoParentSystem.NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, "<>ValidateAndUpdatePickedUnit_LambdaJob0_profilerMarker");
      TargetInfoParentSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668527);
      TargetInfoParentSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668528);
      TargetInfoParentSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668529);
      TargetInfoParentSystem.NativeMethodInfoPtr_ValidateAndUpdatePickedUnit_Private_Data_Entity_Single_Entity_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668530);
      TargetInfoParentSystem.NativeMethodInfoPtr_TryGetCustomName_Private_Boolean_Entity_Boolean_byref_FixedString64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668531);
      TargetInfoParentSystem.NativeMethodInfoPtr_ValidateAndUpdatePickedStructure_Private_Data_Team_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668532);
      TargetInfoParentSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668533);
      TargetInfoParentSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668534);
      TargetInfoParentSystem.NativeMethodInfoPtr___GetEntityQuery_ForValidateAndUpdatePickedUnit_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668535);
      TargetInfoParentSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, 100668536);
    }

    public TargetInfoParentSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TargetInfoParent _TargetInfoParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetInfoParent));
        return pointer == System.IntPtr.Zero ? (TargetInfoParent) null : new TargetInfoParent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetInfoParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _HideHUDBuffQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__HideHUDBuffQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__HideHUDBuffQuery)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _TargetUnitQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetUnitQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetUnitQuery)) = value;
      }
    }

    public unsafe EntityQueryMask _TargetUnitQueryMask
    {
      get
      {
        return *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetUnitQueryMask));
      }
      [param: In] set
      {
        *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetUnitQueryMask)) = value;
      }
    }

    public unsafe EntityQuery _TargetStructureQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetStructureQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetStructureQuery)) = value;
      }
    }

    public unsafe EntityQueryMask _TargetStructureQueryMask
    {
      get
      {
        return *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetStructureQueryMask));
      }
      [param: In] set
      {
        *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr__TargetStructureQueryMask)) = value;
      }
    }

    public unsafe EntityQuery __ValidateAndUpdatePickedUnit_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ValidateAndUpdatePickedUnit_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetInfoParentSystem.NativeFieldInfoPtr___ValidateAndUpdatePickedUnit_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.TargetInfoParentSystem/<>c__DisplayClass13_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass13_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_pickedUnit;
      private static readonly System.IntPtr NativeFieldInfoPtr_totalAbsorb;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ValidateAndUpdatePickedUnit_b__0_Internal_Void_byref_Buff_byref_AbsorbBuff_0;
      [FieldOffset(0)]
      public Entity pickedUnit;
      [FieldOffset(8)]
      public float totalAbsorb;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ValidateAndUpdatePickedUnit_b__0([In] ref Buff buff, [In] ref AbsorbBuff absorbBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref absorbBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ValidateAndUpdatePickedUnit_b__0_Internal_Void_byref_Buff_byref_AbsorbBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr);
        TargetInfoParentSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_pickedUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (pickedUnit));
        TargetInfoParentSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_totalAbsorb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (totalAbsorb));
        TargetInfoParentSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr, 100668537);
        TargetInfoParentSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ValidateAndUpdatePickedUnit_b__0_Internal_Void_byref_Buff_byref_AbsorbBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr, 100668538);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass13_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.TargetInfoParentSystem/ProjectM.UI.<>c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_pickedUnit;
      private static readonly System.IntPtr NativeFieldInfoPtr_totalAbsorb;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_byref_AbsorbBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TargetInfoParentSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity pickedUnit;
      [FieldOffset(8)]
      public float totalAbsorb;
      [FieldOffset(16)]
      public TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1212818, RefRangeEnd = 1212820, XrefRangeStart = 1212818, XrefRangeEnd = 1212820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Buff buff, [In] ref AbsorbBuff absorbBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref absorbBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_byref_AbsorbBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1012957, RefRangeEnd = 1012962, XrefRangeStart = 1012957, XrefRangeEnd = 1012962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TargetInfoParentSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1012962, RefRangeEnd = 1012967, XrefRangeStart = 1012962, XrefRangeEnd = 1012967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TargetInfoParentSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276149, XrefRangeEnd = 1276151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1276159, RefRangeEnd = 1276160, XrefRangeStart = 1276151, XrefRangeEnd = 1276159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1276162, RefRangeEnd = 1276163, XrefRangeStart = 1276160, XrefRangeEnd = 1276162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TargetInfoParentSystem componentSystem,
        ref TargetInfoParentSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TargetInfoParentSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276163, XrefRangeEnd = 1276167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276167, XrefRangeEnd = 1276173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0()
      {
        Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParentSystem>.NativeClassPtr, "<>c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_pickedUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (pickedUnit));
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_totalAbsorb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (totalAbsorb));
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_byref_AbsorbBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668539);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668540);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668541);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668542);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668543);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TargetInfoParentSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668544);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668545);
        TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, 100668546);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_absorbBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TargetInfoParentSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<AbsorbBuff> forParameter_absorbBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1276066, RefRangeEnd = 1276067, XrefRangeStart = 1276060, XrefRangeEnd = 1276066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TargetInfoParentSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TargetInfoParentSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1276073, RefRangeEnd = 1276074, XrefRangeStart = 1276067, XrefRangeEnd = 1276073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_absorbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_absorbBuff));
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TargetInfoParentSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668547);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668548);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_absorbBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbsorbBuff>.Runtime runtime_absorbBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_absorbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_absorbBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.TargetInfoParentSystem/ProjectM.UI.<>c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0/ProjectM.UI.RunWithoutJobSystem_00001270$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00001270$PostfixBurstDelegate");
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668549);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668550);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668551);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668552);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.TargetInfoParentSystem/ProjectM.UI.<>c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0/ProjectM.UI.RunWithoutJobSystem_00001270$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276074, XrefRangeEnd = 1276088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276088, XrefRangeEnd = 1276106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276106, XrefRangeEnd = 1276121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1276148, RefRangeEnd = 1276149, XrefRangeStart = 1276121, XrefRangeEnd = 1276148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00001270$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668553);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668554);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668555);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668556);
          TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668558);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TargetInfoParentSystem.__c__DisplayClass_ValidateAndUpdatePickedUnit_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
