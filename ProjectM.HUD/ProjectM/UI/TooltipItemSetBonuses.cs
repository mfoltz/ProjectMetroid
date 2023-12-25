// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipItemSetBonuses
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipItemSetBonuses : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipSetBonusEntryList;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_EntityManager_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252463, RefRangeEnd = 1252464, XrefRangeStart = 1252414, XrefRangeEnd = 1252463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(EntityManager entityManager, TooltipItemSetBonuses.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemSetBonuses.NativeMethodInfoPtr_SetData_Public_Void_EntityManager_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipItemSetBonuses()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemSetBonuses.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipItemSetBonuses()
    {
      Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipItemSetBonuses));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr);
      TooltipItemSetBonuses.NativeFieldInfoPtr_TooltipSetBonusEntryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr, nameof (TooltipSetBonusEntryList));
      TooltipItemSetBonuses.NativeMethodInfoPtr_SetData_Public_Void_EntityManager_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr, 100666685);
      TooltipItemSetBonuses.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr, 100666686);
    }

    public TooltipItemSetBonuses(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<TooltipSetItemEntry> TooltipSetBonusEntryList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.NativeFieldInfoPtr_TooltipSetBonusEntryList));
        return pointer == System.IntPtr.Zero ? (List<TooltipSetItemEntry>) null : new List<TooltipSetItemEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.NativeFieldInfoPtr_TooltipSetBonusEntryList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemSetInfo;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Dark;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextColor_Normal;

      static Data()
      {
        Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipItemSetBonuses>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr);
        TooltipItemSetBonuses.Data.NativeFieldInfoPtr_ItemSetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr, nameof (ItemSetInfo));
        TooltipItemSetBonuses.Data.NativeFieldInfoPtr_TextColor_Dark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr, nameof (TextColor_Dark));
        TooltipItemSetBonuses.Data.NativeFieldInfoPtr_TextColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr, nameof (TextColor_Normal));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipItemSetBonuses.Data>.NativeClassPtr, data));
      }

      public Il2CppSystem.Nullable<ItemSetInfo> ItemSetInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.Data.NativeFieldInfoPtr_ItemSetInfo);
          return new Il2CppSystem.Nullable<ItemSetInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ItemSetInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.Data.NativeFieldInfoPtr_ItemSetInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ItemSetInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Color TextColor_Dark
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.Data.NativeFieldInfoPtr_TextColor_Dark));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.Data.NativeFieldInfoPtr_TextColor_Dark)) = value;
        }
      }

      public unsafe Color TextColor_Normal
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.Data.NativeFieldInfoPtr_TextColor_Normal));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSetBonuses.Data.NativeFieldInfoPtr_TextColor_Normal)) = value;
        }
      }
    }
  }
}
