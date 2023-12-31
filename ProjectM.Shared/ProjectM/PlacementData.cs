// Decompiled with JetBrains decompiler
// Type: ProjectM.PlacementData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Types;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_Restrictions;
    private static readonly System.IntPtr NativeFieldInfoPtr_Replaces;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachesTo;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAll_Public_Boolean_PlacementData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_Void_PlacementData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public PlacementTypeData Types;
    [FieldOffset(40)]
    public PlacementTypeData Requirements;
    [FieldOffset(80)]
    public PlacementTypeData Restrictions;
    [FieldOffset(120)]
    public PlacementTypeData Replaces;
    [FieldOffset(160)]
    public PlacementTypeData AttachesTo;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732150, XrefRangeEnd = 732156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckAll(PlacementData placementData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &placementData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementData.NativeMethodInfoPtr_CheckAll_Public_Boolean_PlacementData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 732156, RefRangeEnd = 732158, XrefRangeStart = 732156, XrefRangeEnd = 732156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Merge(PlacementData data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementData.NativeMethodInfoPtr_Merge_Public_Void_PlacementData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732158, XrefRangeEnd = 732186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlacementData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PlacementData()
    {
      Il2CppClassPointerStore<PlacementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PlacementData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementData>.NativeClassPtr);
      PlacementData.NativeFieldInfoPtr_Types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, nameof (Types));
      PlacementData.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, nameof (Requirements));
      PlacementData.NativeFieldInfoPtr_Restrictions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, nameof (Restrictions));
      PlacementData.NativeFieldInfoPtr_Replaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, nameof (Replaces));
      PlacementData.NativeFieldInfoPtr_AttachesTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, nameof (AttachesTo));
      PlacementData.NativeMethodInfoPtr_CheckAll_Public_Boolean_PlacementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, 100664687);
      PlacementData.NativeMethodInfoPtr_Merge_Public_Void_PlacementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, 100664688);
      PlacementData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, 100664689);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
