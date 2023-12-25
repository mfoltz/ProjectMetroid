// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ActionWheelPart
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ActionWheelPart : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Part;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabGUID_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomColor;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PrefabGUID_Public_set_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Unlocked_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGUID
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr_get_PrefabGUID_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr_set_PrefabGUID_Public_set_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool Unlocked
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 56397, RefRangeEnd = 56398, XrefRangeStart = 56397, XrefRangeEnd = 56398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr_set_Unlocked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LocalizationKey Text
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr_get_Text_Public_get_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr_set_Text_Public_set_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionWheelPart()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionWheelPart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ActionWheelPart()
    {
      Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ActionWheelPart));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr);
      ActionWheelPart.NativeFieldInfoPtr_Part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, nameof (Part));
      ActionWheelPart.NativeFieldInfoPtr__PrefabGUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, "<PrefabGUID>k__BackingField");
      ActionWheelPart.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, nameof (Type));
      ActionWheelPart.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, "<Unlocked>k__BackingField");
      ActionWheelPart.NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, "<Text>k__BackingField");
      ActionWheelPart.NativeFieldInfoPtr_CustomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, nameof (CustomColor));
      ActionWheelPart.NativeMethodInfoPtr_get_PrefabGUID_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669826);
      ActionWheelPart.NativeMethodInfoPtr_set_PrefabGUID_Public_set_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669827);
      ActionWheelPart.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669828);
      ActionWheelPart.NativeMethodInfoPtr_set_Unlocked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669829);
      ActionWheelPart.NativeMethodInfoPtr_get_Text_Public_get_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669830);
      ActionWheelPart.NativeMethodInfoPtr_set_Text_Public_set_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669831);
      ActionWheelPart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheelPart>.NativeClassPtr, 100669832);
    }

    public ActionWheelPart(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Part
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr_Part));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr_Part), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID _PrefabGUID_k__BackingField
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr__PrefabGUID_k__BackingField));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr__PrefabGUID_k__BackingField)) = value;
      }
    }

    public unsafe ActionWheelData.ActionType Type
    {
      get
      {
        return *(ActionWheelData.ActionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(ActionWheelData.ActionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe bool _Unlocked_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr__Unlocked_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
      }
    }

    public unsafe LocalizationKey _Text_k__BackingField
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr__Text_k__BackingField));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr__Text_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Color> CustomColor
    {
      get
      {
        return *(Nullable_Unboxed<Color>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr_CustomColor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheelPart.NativeFieldInfoPtr_CustomColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Color>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
