// Decompiled with JetBrains decompiler
// Type: ProjectM.BagsContainerSlot
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BagsContainerSlot : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Button;
    private static readonly IntPtr NativeFieldInfoPtr_Text;
    private static readonly IntPtr NativeFieldInfoPtr_TextKey;
    private static readonly IntPtr NativeFieldInfoPtr_ContainerSlot;
    private static readonly IntPtr NativeFieldInfoPtr__SlotIndex;
    private static readonly IntPtr NativeFieldInfoPtr__Target;
    private static readonly IntPtr NativeFieldInfoPtr__BagSlotsText;
    private static readonly IntPtr NativeMethodInfoPtr_get_SlotIndex_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_EntityManager_Entity_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int SlotIndex
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 32748, RefRangeEnd = 32752, XrefRangeStart = 32748, XrefRangeEnd = 32752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BagsContainerSlot.NativeMethodInfoPtr_get_SlotIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity Target
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BagsContainerSlot.NativeMethodInfoPtr_get_Target_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209541, XrefRangeEnd = 1209542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BagsContainerSlot.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1209558, RefRangeEnd = 1209559, XrefRangeStart = 1209542, XrefRangeEnd = 1209558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(EntityManager entityManager, Entity target, int slotIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &target;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &slotIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BagsContainerSlot.NativeMethodInfoPtr_Refresh_Public_Void_EntityManager_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BagsContainerSlot()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BagsContainerSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BagsContainerSlot()
    {
      Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (BagsContainerSlot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr);
      BagsContainerSlot.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (Button));
      BagsContainerSlot.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (Text));
      BagsContainerSlot.NativeFieldInfoPtr_TextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (TextKey));
      BagsContainerSlot.NativeFieldInfoPtr_ContainerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (ContainerSlot));
      BagsContainerSlot.NativeFieldInfoPtr__SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (_SlotIndex));
      BagsContainerSlot.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (_Target));
      BagsContainerSlot.NativeFieldInfoPtr__BagSlotsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, nameof (_BagSlotsText));
      BagsContainerSlot.NativeMethodInfoPtr_get_SlotIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, 100663635);
      BagsContainerSlot.NativeMethodInfoPtr_get_Target_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, 100663636);
      BagsContainerSlot.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, 100663637);
      BagsContainerSlot.NativeMethodInfoPtr_Refresh_Public_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, 100663638);
      BagsContainerSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagsContainerSlot>.NativeClassPtr, 100663639);
    }

    public BagsContainerSlot(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_Button));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_Text));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey TextKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_TextKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_TextKey)) = value;
      }
    }

    public unsafe ItemGridSelectionEntry ContainerSlot
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_ContainerSlot));
        return pointer == IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr_ContainerSlot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _SlotIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr__SlotIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr__SlotIndex)) = value;
      }
    }

    public unsafe Entity _Target
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr__Target));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr__Target)) = value;
      }
    }

    public MemoizedInteger2Text _BagSlotsText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr__BagSlotsText);
        return new MemoizedInteger2Text(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BagsContainerSlot.NativeFieldInfoPtr__BagSlotsText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
