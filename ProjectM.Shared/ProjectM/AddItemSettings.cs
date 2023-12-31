// Decompiled with JetBrains decompiler
// Type: ProjectM.AddItemSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AddItemSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemDataMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyFillEmptySlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyCheckOneSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropRemainder;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipIfPossible;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryInstanceIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AddItemSettings_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Boolean_Entity_Nullable_Unboxed_1_Int32_Boolean_Boolean_Boolean_Nullable_Unboxed_1_Int32_0;
    [FieldOffset(0)]
    public EntityManager EntityManager;
    [FieldOffset(8)]
    public NativeHashMap<PrefabGUID, ItemData> ItemDataMap;
    [FieldOffset(24)]
    public Entity PreviousItemEntity;
    [FieldOffset(32)]
    public Nullable_Unboxed<int> StartIndex;
    [FieldOffset(40)]
    public bool OnlyFillEmptySlots;
    [FieldOffset(41)]
    public bool OnlyCheckOneSlot;
    [FieldOffset(42)]
    public bool DropRemainder;
    [FieldOffset(43)]
    public bool EquipIfPossible;
    [FieldOffset(44)]
    public Nullable_Unboxed<int> InventoryInstanceIndex;

    [CallerCount(36)]
    [CachedScanResults(RefRangeStart = 738456, RefRangeEnd = 738492, XrefRangeStart = 738456, XrefRangeEnd = 738456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AddItemSettings Create(
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, ItemData> itemDataMap,
      bool equipIfPossible = false,
      Entity previousItemEntity = default (Entity),
      Nullable_Unboxed<int> startIndex = default (Nullable_Unboxed<int>),
      bool onlyFillEmptySlots = false,
      bool onlyCheckOneSlot = false,
      bool dropRemainder = false,
      Nullable_Unboxed<int> inventoryInstanceIndex = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemDataMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &equipIfPossible;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &previousItemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyFillEmptySlots;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyCheckOneSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &dropRemainder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryInstanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddItemSettings.NativeMethodInfoPtr_Create_Public_Static_AddItemSettings_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Boolean_Entity_Nullable_Unboxed_1_Int32_Boolean_Boolean_Boolean_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AddItemSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AddItemSettings()
    {
      Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AddItemSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr);
      AddItemSettings.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (EntityManager));
      AddItemSettings.NativeFieldInfoPtr_ItemDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (ItemDataMap));
      AddItemSettings.NativeFieldInfoPtr_PreviousItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (PreviousItemEntity));
      AddItemSettings.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (StartIndex));
      AddItemSettings.NativeFieldInfoPtr_OnlyFillEmptySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (OnlyFillEmptySlots));
      AddItemSettings.NativeFieldInfoPtr_OnlyCheckOneSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (OnlyCheckOneSlot));
      AddItemSettings.NativeFieldInfoPtr_DropRemainder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (DropRemainder));
      AddItemSettings.NativeFieldInfoPtr_EquipIfPossible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (EquipIfPossible));
      AddItemSettings.NativeFieldInfoPtr_InventoryInstanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, nameof (InventoryInstanceIndex));
      AddItemSettings.NativeMethodInfoPtr_Create_Public_Static_AddItemSettings_EntityManager_NativeHashMap_2_PrefabGUID_ItemData_Boolean_Entity_Nullable_Unboxed_1_Int32_Boolean_Boolean_Boolean_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, 100665209);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddItemSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
