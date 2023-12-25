// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StunDragData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public static class StunDragData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Icon_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Type_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IconConsumed_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Static_Void_Sprite_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetIcon_Public_Static_Boolean_byref_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetData_Public_Static_Boolean_byref_Object_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetData_Public_Static_Boolean_byref_T_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDataAndType_Public_Static_Boolean_byref_T_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearData_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Icon_Public_Static_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Icon_Private_Static_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasData_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HasData_Private_Static_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Private_Static_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_Static_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Private_Static_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IconConsumed_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IconConsumed_Private_Static_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndSetInventoryDrag_Public_Static_Void_EntityManager_Entity_ItemGridSelectionEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndSetInventoryDrag_Public_Static_Void_EntityManager_NetworkId_ItemGridSelectionEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeIcon_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetConsumeIcon_Public_Static_Void_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1287852, RefRangeEnd = 1287861, XrefRangeStart = 1287841, XrefRangeEnd = 1287852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetData(Sprite viewIcon, string type, Il2CppSystem.Object data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) viewIcon);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_SetData_Public_Static_Void_Sprite_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287867, RefRangeEnd = 1287868, XrefRangeStart = 1287861, XrefRangeEnd = 1287867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetIcon(out Sprite icon)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_TryGetIcon_Public_Static_Boolean_byref_Sprite_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Sprite local = ref icon;
      System.IntPtr pointer = zero;
      Sprite sprite = pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      local = sprite;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287868, XrefRangeEnd = 1287873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetData(out Il2CppSystem.Object data, string type = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_TryGetData_Public_Static_Boolean_byref_Object_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Object local = ref data;
      System.IntPtr pointer = zero;
      Il2CppSystem.Object @object = pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      local = @object;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287873, XrefRangeEnd = 1287877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetData<T>(out T data, string type = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
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
        local1 = ref data;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.MethodInfoStoreGeneric_TryGetData_Public_Static_Boolean_byref_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref data;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287877, XrefRangeEnd = 1287884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetDataAndType<T>(out T data, out string type)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero1);
      }
      else
        local1 = ref data;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StunDragData.MethodInfoStoreGeneric_TryGetDataAndType_Public_Static_Boolean_byref_T_byref_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref data;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      type = IL2CPP.Il2CppStringToManaged(zero2);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287897, RefRangeEnd = 1287898, XrefRangeStart = 1287884, XrefRangeEnd = 1287897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearData()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_ClearData_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static unsafe Sprite Icon
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287898, XrefRangeEnd = 1287900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_get_Icon_Public_Static_get_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287900, XrefRangeEnd = 1287903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_set_Icon_Private_Static_set_Void_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public static unsafe bool HasData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287903, XrefRangeEnd = 1287905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_get_HasData_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287905, XrefRangeEnd = 1287907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_set_HasData_Private_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public static unsafe string Type
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287907, XrefRangeEnd = 1287909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_get_Type_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287909, XrefRangeEnd = 1287912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_set_Type_Private_Static_set_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public static unsafe Il2CppSystem.Object Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287912, XrefRangeEnd = 1287914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_get_Data_Public_Static_get_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287914, XrefRangeEnd = 1287917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_set_Data_Private_Static_set_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public static unsafe bool IconConsumed
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287917, XrefRangeEnd = 1287919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_get_IconConsumed_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287919, XrefRangeEnd = 1287921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_set_IconConsumed_Private_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287921, XrefRangeEnd = 1287942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateAndSetInventoryDrag(
      EntityManager entityManager,
      Entity target,
      ItemGridSelectionEntry entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_CreateAndSetInventoryDrag_Public_Static_Void_EntityManager_Entity_ItemGridSelectionEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1287960, RefRangeEnd = 1287963, XrefRangeStart = 1287942, XrefRangeEnd = 1287960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateAndSetInventoryDrag(
      EntityManager entityManager,
      NetworkId fromInventory,
      ItemGridSelectionEntry entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_CreateAndSetInventoryDrag_Public_Static_Void_EntityManager_NetworkId_ItemGridSelectionEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1287965, RefRangeEnd = 1287967, XrefRangeStart = 1287963, XrefRangeEnd = 1287965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConsumeIcon()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_ConsumeIcon_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287969, RefRangeEnd = 1287970, XrefRangeStart = 1287967, XrefRangeEnd = 1287969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResetConsumeIcon()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDragData.NativeMethodInfoPtr_ResetConsumeIcon_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunDragData()
    {
      Il2CppClassPointerStore<StunDragData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (StunDragData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunDragData>.NativeClassPtr);
      StunDragData.NativeFieldInfoPtr__Icon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, "<Icon>k__BackingField");
      StunDragData.NativeFieldInfoPtr__HasData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, "<HasData>k__BackingField");
      StunDragData.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, "<Type>k__BackingField");
      StunDragData.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, "<Data>k__BackingField");
      StunDragData.NativeFieldInfoPtr__IconConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, "<IconConsumed>k__BackingField");
      StunDragData.NativeMethodInfoPtr_SetData_Public_Static_Void_Sprite_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669586);
      StunDragData.NativeMethodInfoPtr_TryGetIcon_Public_Static_Boolean_byref_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669587);
      StunDragData.NativeMethodInfoPtr_TryGetData_Public_Static_Boolean_byref_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669588);
      StunDragData.NativeMethodInfoPtr_TryGetData_Public_Static_Boolean_byref_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669589);
      StunDragData.NativeMethodInfoPtr_TryGetDataAndType_Public_Static_Boolean_byref_T_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669590);
      StunDragData.NativeMethodInfoPtr_ClearData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669591);
      StunDragData.NativeMethodInfoPtr_get_Icon_Public_Static_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669592);
      StunDragData.NativeMethodInfoPtr_set_Icon_Private_Static_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669593);
      StunDragData.NativeMethodInfoPtr_get_HasData_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669594);
      StunDragData.NativeMethodInfoPtr_set_HasData_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669595);
      StunDragData.NativeMethodInfoPtr_get_Type_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669596);
      StunDragData.NativeMethodInfoPtr_set_Type_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669597);
      StunDragData.NativeMethodInfoPtr_get_Data_Public_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669598);
      StunDragData.NativeMethodInfoPtr_set_Data_Private_Static_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669599);
      StunDragData.NativeMethodInfoPtr_get_IconConsumed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669600);
      StunDragData.NativeMethodInfoPtr_set_IconConsumed_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669601);
      StunDragData.NativeMethodInfoPtr_CreateAndSetInventoryDrag_Public_Static_Void_EntityManager_Entity_ItemGridSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669602);
      StunDragData.NativeMethodInfoPtr_CreateAndSetInventoryDrag_Public_Static_Void_EntityManager_NetworkId_ItemGridSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669603);
      StunDragData.NativeMethodInfoPtr_ConsumeIcon_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669604);
      StunDragData.NativeMethodInfoPtr_ResetConsumeIcon_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDragData>.NativeClassPtr, 100669605);
    }

    public StunDragData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Sprite _Icon_k__BackingField
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StunDragData.NativeFieldInfoPtr__Icon_k__BackingField, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunDragData.NativeFieldInfoPtr__Icon_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool _HasData_k__BackingField
    {
      get
      {
        bool dataKBackingField;
        IL2CPP.il2cpp_field_static_get_value(StunDragData.NativeFieldInfoPtr__HasData_k__BackingField, (void*) &dataKBackingField);
        return dataKBackingField;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunDragData.NativeFieldInfoPtr__HasData_k__BackingField, (void*) &value);
      }
    }

    public static unsafe string _Type_k__BackingField
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(StunDragData.NativeFieldInfoPtr__Type_k__BackingField, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunDragData.NativeFieldInfoPtr__Type_k__BackingField, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Il2CppSystem.Object _Data_k__BackingField
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StunDragData.NativeFieldInfoPtr__Data_k__BackingField, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunDragData.NativeFieldInfoPtr__Data_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool _IconConsumed_k__BackingField
    {
      get
      {
        bool consumedKBackingField;
        IL2CPP.il2cpp_field_static_get_value(StunDragData.NativeFieldInfoPtr__IconConsumed_k__BackingField, (void*) &consumedKBackingField);
        return consumedKBackingField;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunDragData.NativeFieldInfoPtr__IconConsumed_k__BackingField, (void*) &value);
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGetData_Public_Static_Boolean_byref_T_String_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(StunDragData.NativeMethodInfoPtr_TryGetData_Public_Static_Boolean_byref_T_String_0, Il2CppClassPointerStore<StunDragData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetDataAndType_Public_Static_Boolean_byref_T_byref_String_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(StunDragData.NativeMethodInfoPtr_TryGetDataAndType_Public_Static_Boolean_byref_T_byref_String_0, Il2CppClassPointerStore<StunDragData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
