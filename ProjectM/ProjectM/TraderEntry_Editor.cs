// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderEntry_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class TraderEntry_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cost;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_StockData;

    static TraderEntry_Editor()
    {
      Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderEntry_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr);
      TraderEntry_Editor.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, nameof (Weight));
      TraderEntry_Editor.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, nameof (Cost));
      TraderEntry_Editor.NativeFieldInfoPtr_SharedCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, nameof (SharedCost));
      TraderEntry_Editor.NativeFieldInfoPtr_OutItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, nameof (OutItems));
      TraderEntry_Editor.NativeFieldInfoPtr_StockData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, nameof (StockData));
    }

    public TraderEntry_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TraderEntry_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderEntry_Editor>.NativeClassPtr, data));
    }

    public unsafe int Weight
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_Weight));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_Weight)) = value;
      }
    }

    public unsafe List<ItemCost> Cost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_Cost));
        return pointer == System.IntPtr.Zero ? (List<ItemCost>) null : new List<ItemCost>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_Cost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_SharedCost));
        return pointer == System.IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_SharedCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemOutput_Editor> OutItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_OutItems));
        return pointer == System.IntPtr.Zero ? (List<ItemOutput_Editor>) null : new List<ItemOutput_Editor>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_OutItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TraderItemStockDataAsset StockData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_StockData));
        return pointer == System.IntPtr.Zero ? (TraderItemStockDataAsset) null : new TraderItemStockDataAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderEntry_Editor.NativeFieldInfoPtr_StockData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
