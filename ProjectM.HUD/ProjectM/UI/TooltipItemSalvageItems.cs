// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipItemSalvageItems
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipItemSalvageItems : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_SalvageItemsList;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252413, RefRangeEnd = 1252414, XrefRangeStart = 1252371, XrefRangeEnd = 1252413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TooltipItemSalvageItems.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemSalvageItems.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipItemSalvageItems()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemSalvageItems.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipItemSalvageItems()
    {
      Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipItemSalvageItems));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr);
      TooltipItemSalvageItems.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr, nameof (Header));
      TooltipItemSalvageItems.NativeFieldInfoPtr_SalvageItemsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr, nameof (SalvageItemsList));
      TooltipItemSalvageItems.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr, 100666683);
      TooltipItemSalvageItems.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr, 100666684);
    }

    public TooltipItemSalvageItems(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Header
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.NativeFieldInfoPtr_Header));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WorkstationRequirementEntry> SalvageItemsList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.NativeFieldInfoPtr_SalvageItemsList));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRequirementEntry>) null : new List<WorkstationRequirementEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.NativeFieldInfoPtr_SalvageItemsList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SalvageItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShowAmount;

      static Data()
      {
        Il2CppClassPointerStore<TooltipItemSalvageItems.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipItemSalvageItems>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemSalvageItems.Data>.NativeClassPtr);
        TooltipItemSalvageItems.Data.NativeFieldInfoPtr_SalvageItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSalvageItems.Data>.NativeClassPtr, nameof (SalvageItems));
        TooltipItemSalvageItems.Data.NativeFieldInfoPtr_ShowAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemSalvageItems.Data>.NativeClassPtr, nameof (ShowAmount));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipItemSalvageItems.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipItemSalvageItems.Data>.NativeClassPtr, data));
      }

      public unsafe List<CostData> SalvageItems
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.Data.NativeFieldInfoPtr_SalvageItems));
          return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.Data.NativeFieldInfoPtr_SalvageItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool ShowAmount
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.Data.NativeFieldInfoPtr_ShowAmount));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemSalvageItems.Data.NativeFieldInfoPtr_ShowAmount)) = value;
        }
      }
    }
  }
}
