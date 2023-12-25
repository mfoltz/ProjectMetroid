// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.RefinementstationRecipeItem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class RefinementstationRecipeItem : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__CountText;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_RefinementstationRecipeItem_Data_ControllerType_GridSelectionGroup_2_RefinementstationRecipeItem_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHilighted_Private_Static_Boolean_ControllerType_GridSelectionGroup_2_RefinementstationRecipeItem_Data_RefinementstationRecipeItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID Guid
    {
      [CallerCount(15), CachedScanResults(RefRangeStart = 93740, RefRangeEnd = 93755, XrefRangeStart = 93740, XrefRangeEnd = 93755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeItem.NativeMethodInfoPtr_get_Guid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1244145, RefRangeEnd = 1244147, XrefRangeStart = 1244129, XrefRangeEnd = 1244145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      RefinementstationRecipeItem entry,
      RefinementstationRecipeItem.Data data,
      ControllerType controllerType,
      GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data> parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeItem.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_RefinementstationRecipeItem_Data_ControllerType_GridSelectionGroup_2_RefinementstationRecipeItem_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244147, XrefRangeEnd = 1244148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsHilighted(
      ControllerType controllerType,
      GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data> parent,
      RefinementstationRecipeItem entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeItem.NativeMethodInfoPtr_IsHilighted_Private_Static_Boolean_ControllerType_GridSelectionGroup_2_RefinementstationRecipeItem_Data_RefinementstationRecipeItem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RefinementstationRecipeItem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RefinementstationRecipeItem()
    {
      Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (RefinementstationRecipeItem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr);
      RefinementstationRecipeItem.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, nameof (Selected));
      RefinementstationRecipeItem.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, nameof (Icon));
      RefinementstationRecipeItem.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, nameof (Count));
      RefinementstationRecipeItem.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, nameof (_Guid));
      RefinementstationRecipeItem.NativeFieldInfoPtr__CountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, nameof (_CountText));
      RefinementstationRecipeItem.NativeMethodInfoPtr_get_Guid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, 100666208);
      RefinementstationRecipeItem.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_RefinementstationRecipeItem_Data_ControllerType_GridSelectionGroup_2_RefinementstationRecipeItem_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, 100666209);
      RefinementstationRecipeItem.NativeMethodInfoPtr_IsHilighted_Private_Static_Boolean_ControllerType_GridSelectionGroup_2_RefinementstationRecipeItem_Data_RefinementstationRecipeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, 100666210);
      RefinementstationRecipeItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, 100666211);
    }

    public RefinementstationRecipeItem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Selected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr_Selected));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Count
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr_Count));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr_Count), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID _Guid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr__Guid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr__Guid)) = value;
      }
    }

    public MemoizedIntegerText _CountText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr__CountText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.NativeFieldInfoPtr__CountText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sprite;
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;

      static Data()
      {
        Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationRecipeItem>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr);
        RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr, nameof (Guid));
        RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr, nameof (Sprite));
        RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr, nameof (Count));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefinementstationRecipeItem.Data>.NativeClassPtr, data));
      }

      public unsafe PrefabGUID Guid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Guid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Guid)) = value;
        }
      }

      public unsafe Sprite Sprite
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Sprite));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeItem.Data.NativeFieldInfoPtr_Count)) = value;
        }
      }
    }
  }
}
