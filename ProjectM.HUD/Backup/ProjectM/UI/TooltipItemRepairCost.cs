// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipItemRepairCost
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
  public class TooltipItemRepairCost : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairCostList;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252370, RefRangeEnd = 1252371, XrefRangeStart = 1252328, XrefRangeEnd = 1252370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TooltipItemRepairCost.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemRepairCost.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipItemRepairCost()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemRepairCost.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipItemRepairCost()
    {
      Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipItemRepairCost));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr);
      TooltipItemRepairCost.NativeFieldInfoPtr_RepairCostList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr, nameof (RepairCostList));
      TooltipItemRepairCost.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr, 100666681);
      TooltipItemRepairCost.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr, 100666682);
    }

    public TooltipItemRepairCost(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<WorkstationRequirementEntry> RepairCostList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemRepairCost.NativeFieldInfoPtr_RepairCostList));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRequirementEntry>) null : new List<WorkstationRequirementEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemRepairCost.NativeFieldInfoPtr_RepairCostList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RepairCost;

      static Data()
      {
        Il2CppClassPointerStore<TooltipItemRepairCost.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipItemRepairCost>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemRepairCost.Data>.NativeClassPtr);
        TooltipItemRepairCost.Data.NativeFieldInfoPtr_RepairCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemRepairCost.Data>.NativeClassPtr, nameof (RepairCost));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipItemRepairCost.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipItemRepairCost.Data>.NativeClassPtr, data));
      }

      public Il2CppSystem.Nullable<RepairCost> RepairCost
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemRepairCost.Data.NativeFieldInfoPtr_RepairCost);
          return new Il2CppSystem.Nullable<RepairCost>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<RepairCost>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemRepairCost.Data.NativeFieldInfoPtr_RepairCost), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<RepairCost>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
