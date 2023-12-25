// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipRecipeRequiredItems
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
  public class TooltipRecipeRequiredItems : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredItemsList;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1252676, RefRangeEnd = 1252679, XrefRangeStart = 1252636, XrefRangeEnd = 1252676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TooltipRecipeRequiredItems.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipRecipeRequiredItems.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipRecipeRequiredItems()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipRecipeRequiredItems.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipRecipeRequiredItems()
    {
      Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipRecipeRequiredItems));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr);
      TooltipRecipeRequiredItems.NativeFieldInfoPtr_RequiredItemsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr, nameof (RequiredItemsList));
      TooltipRecipeRequiredItems.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr, 100666695);
      TooltipRecipeRequiredItems.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr, 100666696);
    }

    public TooltipRecipeRequiredItems(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<WorkstationRequirementEntry> RequiredItemsList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipRecipeRequiredItems.NativeFieldInfoPtr_RequiredItemsList));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRequirementEntry>) null : new List<WorkstationRequirementEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipRecipeRequiredItems.NativeFieldInfoPtr_RequiredItemsList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShowAmount;

      static Data()
      {
        Il2CppClassPointerStore<TooltipRecipeRequiredItems.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipRecipeRequiredItems>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipRecipeRequiredItems.Data>.NativeClassPtr);
        TooltipRecipeRequiredItems.Data.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipRecipeRequiredItems.Data>.NativeClassPtr, nameof (Requirements));
        TooltipRecipeRequiredItems.Data.NativeFieldInfoPtr_ShowAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipRecipeRequiredItems.Data>.NativeClassPtr, nameof (ShowAmount));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipRecipeRequiredItems.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipRecipeRequiredItems.Data>.NativeClassPtr, data));
      }

      public unsafe List<CostData> Requirements
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipRecipeRequiredItems.Data.NativeFieldInfoPtr_Requirements));
          return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipRecipeRequiredItems.Data.NativeFieldInfoPtr_Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool ShowAmount
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipRecipeRequiredItems.Data.NativeFieldInfoPtr_ShowAmount));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipRecipeRequiredItems.Data.NativeFieldInfoPtr_ShowAmount)) = value;
        }
      }
    }
  }
}
