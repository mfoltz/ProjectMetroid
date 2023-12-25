// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipSpellModEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipSpellModEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_TierParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_TierMarkers;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252827, RefRangeEnd = 1252828, XrefRangeStart = 1252819, XrefRangeEnd = 1252827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TooltipSpellModEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipSpellModEntry.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipSpellModEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipSpellModEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipSpellModEntry()
    {
      Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipSpellModEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr);
      TooltipSpellModEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr, nameof (Name));
      TooltipSpellModEntry.NativeFieldInfoPtr_TierParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr, nameof (TierParent));
      TooltipSpellModEntry.NativeFieldInfoPtr_TierMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr, nameof (TierMarkers));
      TooltipSpellModEntry.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr, 100666707);
      TooltipSpellModEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr, 100666708);
    }

    public TooltipSpellModEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TierParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.NativeFieldInfoPtr_TierParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.NativeFieldInfoPtr_TierParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<RectTransform> TierMarkers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.NativeFieldInfoPtr_TierMarkers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.NativeFieldInfoPtr_TierMarkers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr_Tier;

      static Data()
      {
        Il2CppClassPointerStore<TooltipSpellModEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipSpellModEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipSpellModEntry.Data>.NativeClassPtr);
        TooltipSpellModEntry.Data.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellModEntry.Data>.NativeClassPtr, nameof (Text));
        TooltipSpellModEntry.Data.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellModEntry.Data>.NativeClassPtr, nameof (Tier));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipSpellModEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipSpellModEntry.Data>.NativeClassPtr, data));
      }

      public LocalizedString Text
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.Data.NativeFieldInfoPtr_Text);
          return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.Data.NativeFieldInfoPtr_Text), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> Tier
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.Data.NativeFieldInfoPtr_Tier));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellModEntry.Data.NativeFieldInfoPtr_Tier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
