// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipBloodQualityEffects
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipBloodQualityEffects : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipBloodBuffEntryList;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BloodTypeName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BloodTypeNameVBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_AnyPercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_NoBloodBuffs;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_EntityManager_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252290, RefRangeEnd = 1252291, XrefRangeStart = 1252198, XrefRangeEnd = 1252290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(EntityManager entityManager, TooltipBloodQualityEffects.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipBloodQualityEffects.NativeMethodInfoPtr_SetData_Public_Void_EntityManager_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipBloodQualityEffects()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipBloodQualityEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipBloodQualityEffects()
    {
      Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipBloodQualityEffects));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr);
      TooltipBloodQualityEffects.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (Header));
      TooltipBloodQualityEffects.NativeFieldInfoPtr_TooltipBloodBuffEntryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (TooltipBloodBuffEntryList));
      TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_BloodTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (LKey_BloodTypeName));
      TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_BloodTypeNameVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (LKey_BloodTypeNameVBlood));
      TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_AnyPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (LKey_AnyPercent));
      TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_NoBloodBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (LKey_NoBloodBuffs));
      TooltipBloodQualityEffects.NativeMethodInfoPtr_SetData_Public_Void_EntityManager_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, 100666677);
      TooltipBloodQualityEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, 100666678);
    }

    public TooltipBloodQualityEffects(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Header
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_Header));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipBloodBuffEntry> TooltipBloodBuffEntryList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_TooltipBloodBuffEntryList));
        return pointer == System.IntPtr.Zero ? (List<TooltipBloodBuffEntry>) null : new List<TooltipBloodBuffEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_TooltipBloodBuffEntryList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_BloodTypeName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_BloodTypeName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_BloodTypeName)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BloodTypeNameVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_BloodTypeNameVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_BloodTypeNameVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AnyPercent
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_AnyPercent));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_AnyPercent)) = value;
      }
    }

    public unsafe LocalizationKey LKey_NoBloodBuffs
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_NoBloodBuffs));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.NativeFieldInfoPtr_LKey_NoBloodBuffs)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodInfo;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Normal;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Dark;

      static Data()
      {
        Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipBloodQualityEffects>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr);
        TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_BloodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr, nameof (BloodInfo));
        TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_TextColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr, nameof (TextColor_Normal));
        TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_TextColor_Dark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr, nameof (TextColor_Dark));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipBloodQualityEffects.Data>.NativeClassPtr, data));
      }

      public Il2CppSystem.Nullable<BloodBuffInfo> BloodInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_BloodInfo);
          return new Il2CppSystem.Nullable<BloodBuffInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<BloodBuffInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_BloodInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<BloodBuffInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Color TextColor_Normal
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_TextColor_Normal));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_TextColor_Normal)) = value;
        }
      }

      public unsafe Color TextColor_Dark
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_TextColor_Dark));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipBloodQualityEffects.Data.NativeFieldInfoPtr_TextColor_Dark)) = value;
        }
      }
    }
  }
}
