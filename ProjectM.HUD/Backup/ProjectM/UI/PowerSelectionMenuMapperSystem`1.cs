// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PowerSelectionMenuMapperSystem`1
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class PowerSelectionMenuMapperSystem<TMenu> : FullscreenMenuViewMapperSystem<TMenu> where TMenu : PowerSelectionMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedPower;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedPowersCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIAssetSubSceneLoader;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAbilityEquipped_Protected_Abstract_Virtual_New_Void_Int32_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMappedAbilities_Protected_Abstract_Virtual_New_Void_NativeList_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandlePowerLeftClicked_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandlePowerBeginDrag_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_Int32_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockedFirstPowerComparison_Private_Int32_Data_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPowerData_Private_Boolean_PrefabGUID_Boolean_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityBarEntryData_Private_Boolean_PrefabGUID_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTwoSplitLayout_Private_Static_Void_SelectionGroupBase_2_TEntry_TData_SelectionGroupBase_2_TEntry_TData_List_1_TData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Private_Static_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public virtual unsafe void OnAbilityEquipped(int slotIndex, PrefabGUID ability)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &slotIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ability;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnAbilityEquipped_Protected_Abstract_Virtual_New_Void_Int32_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void GetMappedAbilities(NativeList<PrefabGUID> result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_GetMappedAbilities_Protected_Abstract_Virtual_New_Void_NativeList_1_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262069, XrefRangeEnd = 1262075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnMenuCreated()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262075, XrefRangeEnd = 1262085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnMenuEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262085, XrefRangeEnd = 1262087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandlePowerLeftClicked(
      GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> group,
      int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_HandlePowerLeftClicked_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262087, XrefRangeEnd = 1262094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandlePowerBeginDrag(
      GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> group,
      int entryIndex,
      PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_HandlePowerBeginDrag_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262094, XrefRangeEnd = 1262196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int UnlockedFirstPowerComparison(
      PowerSelectionMenu_PowerEntry.Data x,
      PowerSelectionMenu_PowerEntry.Data y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) y));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_UnlockedFirstPowerComparison_Private_Int32_Data_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262196, XrefRangeEnd = 1262211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPowerData(
      PrefabGUID powerPrefabGuid,
      bool skipProgressionCheck,
      out PowerSelectionMenu_PowerEntry.Data result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &powerPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &skipProgressionCheck;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_TryGetPowerData_Private_Boolean_PrefabGUID_Boolean_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PowerSelectionMenu_PowerEntry.Data local = ref result;
      System.IntPtr pointer = zero;
      PowerSelectionMenu_PowerEntry.Data data = pointer == System.IntPtr.Zero ? (PowerSelectionMenu_PowerEntry.Data) null : new PowerSelectionMenu_PowerEntry.Data(pointer);
      local = data;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262211, XrefRangeEnd = 1262219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAbilityBarEntryData(
      PrefabGUID prefabGuid,
      out AbilityBarEntry.Data result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_TryGetAbilityBarEntryData_Private_Boolean_PrefabGUID_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AbilityBarEntry.Data local = ref result;
      System.IntPtr pointer = zero;
      AbilityBarEntry.Data data = pointer == System.IntPtr.Zero ? (AbilityBarEntry.Data) null : new AbilityBarEntry.Data(pointer);
      local = data;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262219, XrefRangeEnd = 1262237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshTwoSplitLayout<TEntry, TData>(
      SelectionGroupBase<TEntry, TData> group0,
      SelectionGroupBase<TEntry, TData> group1,
      List<TData> datas,
      int maxItemsPerRow)
      where TEntry : GridSelectionEntry
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group0);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) datas);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxItemsPerRow;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TEntry>.MethodInfoStoreGeneric_RefreshTwoSplitLayout_Private_Static_Void_SelectionGroupBase_2_TEntry_TData_SelectionGroupBase_2_TEntry_TData_List_1_TData_Int32_0\u00602<TData>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262237, RefRangeEnd = 1262238, XrefRangeStart = 1262237, XrefRangeEnd = 1262237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Fail<T>(out T result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref result;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<T>.MethodInfoStoreGeneric_Fail_Private_Static_Boolean_byref_T_0\u00601.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref result;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262249, RefRangeEnd = 1262251, XrefRangeStart = 1262238, XrefRangeEnd = 1262249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PowerSelectionMenuMapperSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262251, XrefRangeEnd = 1262263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_0(
      GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> group)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262263, XrefRangeEnd = 1262275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_1(
      GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> group)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262276, RefRangeEnd = 1262278, XrefRangeStart = 1262275, XrefRangeEnd = 1262276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PowerSelectionMenuMapperSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", "PowerSelectionMenuMapperSystem`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMenu>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr);
      PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__SelectedPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, nameof (_SelectedPower));
      PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__SelectedPowersCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, nameof (_SelectedPowersCache));
      PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, nameof (_UIAssetSubSceneLoader));
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnAbilityEquipped_Protected_Abstract_Virtual_New_Void_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667358);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_GetMappedAbilities_Protected_Abstract_Virtual_New_Void_NativeList_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667359);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667360);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667361);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_HandlePowerLeftClicked_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667362);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_HandlePowerBeginDrag_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667363);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667364);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_UnlockedFirstPowerComparison_Private_Int32_Data_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667365);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_TryGetPowerData_Private_Boolean_PrefabGUID_Boolean_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667366);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_TryGetAbilityBarEntryData_Private_Boolean_PrefabGUID_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667367);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_RefreshTwoSplitLayout_Private_Static_Void_SelectionGroupBase_2_TEntry_TData_SelectionGroupBase_2_TEntry_TData_List_1_TData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667368);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_Fail_Private_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667369);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667370);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667371);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_Method_Private_Void_GenericSelectionGroup_2_PowerSelectionMenu_PowerEntry_Data_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667372);
      PowerSelectionMenuMapperSystem<TMenu>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, 100667373);
    }

    public PowerSelectionMenuMapperSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGUID _SelectedPower
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__SelectedPower));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__SelectedPower)) = value;
      }
    }

    public unsafe List<PowerSelectionMenu_PowerEntry.Data> _SelectedPowersCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__SelectedPowersCache));
        return pointer == System.IntPtr.Zero ? (List<PowerSelectionMenu_PowerEntry.Data>) null : new List<PowerSelectionMenu_PowerEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__SelectedPowersCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _UIAssetSubSceneLoader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__UIAssetSubSceneLoader));
        return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.NativeFieldInfoPtr__UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public struct PowerDragData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityId;
      public PrefabGUID AbilityId;

      static PowerDragData()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.PowerDragData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, nameof (PowerDragData<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMenu>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.PowerDragData>.NativeClassPtr);
        PowerSelectionMenuMapperSystem<TMenu>.PowerDragData.NativeFieldInfoPtr_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.PowerDragData>.NativeClassPtr, nameof (AbilityId));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.PowerDragData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.PowerSelectionMenuMapperSystem`1/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_group;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnMenuEnabled_b__2_Internal_Void_Int32_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262068, XrefRangeEnd = 1262069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnMenuEnabled_b__2(int entryIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entryIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeMethodInfoPtr__OnMenuEnabled_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, "<>c__DisplayClass7_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMenu>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr);
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr, nameof (group));
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr, 100667374);
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeMethodInfoPtr__OnMenuEnabled_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0>.NativeClassPtr, 100667375);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> group
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeFieldInfoPtr_group));
          return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>) null : new GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PowerSelectionMenuMapperSystem<TMenu> __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PowerSelectionMenuMapperSystem<TMenu>) null : new PowerSelectionMenuMapperSystem<TMenu>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PowerSelectionMenuMapperSystem`1/<>c__DisplayClass7_1")]
    public sealed class __c__DisplayClass7_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_group;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnMenuEnabled_b__3_Internal_Void_Int32_PointerEventData_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _OnMenuEnabled_b__3(int entryIndex, PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entryIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeMethodInfoPtr__OnMenuEnabled_b__3_Internal_Void_Int32_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_1()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, "<>c__DisplayClass7_1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMenu>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr);
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr, nameof (group));
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr, "<>4__this");
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr, 100667376);
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeMethodInfoPtr__OnMenuEnabled_b__3_Internal_Void_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1>.NativeClassPtr, 100667377);
      }

      public __c__DisplayClass7_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> group
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeFieldInfoPtr_group));
          return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>) null : new GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PowerSelectionMenuMapperSystem<TMenu> __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PowerSelectionMenuMapperSystem<TMenu>) null : new PowerSelectionMenuMapperSystem<TMenu>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.PowerSelectionMenuMapperSystem`1/<>c__DisplayClass7_2")]
    public sealed class __c__DisplayClass7_2 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_index;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnMenuEnabled_b__4_Internal_Void_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _OnMenuEnabled_b__4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeMethodInfoPtr__OnMenuEnabled_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_2()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>>.NativeClassPtr, "<>c__DisplayClass7_2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMenu>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr);
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr, nameof (index));
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr, "<>4__this");
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr, 100667378);
        PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeMethodInfoPtr__OnMenuEnabled_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2>.NativeClassPtr, 100667379);
      }

      public __c__DisplayClass7_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int index
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeFieldInfoPtr_index));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeFieldInfoPtr_index)) = value;
        }
      }

      public unsafe PowerSelectionMenuMapperSystem<TMenu> __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PowerSelectionMenuMapperSystem<TMenu>) null : new PowerSelectionMenuMapperSystem<TMenu>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenuMapperSystem<TMenu>.__c__DisplayClass7_2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_RefreshTwoSplitLayout_Private_Static_Void_SelectionGroupBase_2_TEntry_TData_SelectionGroupBase_2_TEntry_TData_List_1_TData_Int32_0\u00602<TData>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PowerSelectionMenuMapperSystem<TEntry>.NativeMethodInfoPtr_RefreshTwoSplitLayout_Private_Static_Void_SelectionGroupBase_2_TEntry_TData_SelectionGroupBase_2_TEntry_TData_List_1_TData_Int32_0, Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<TEntry>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Fail_Private_Static_Boolean_byref_T_0\u00601
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PowerSelectionMenuMapperSystem<T>.NativeMethodInfoPtr_Fail_Private_Static_Boolean_byref_T_0, Il2CppClassPointerStore<PowerSelectionMenuMapperSystem<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
