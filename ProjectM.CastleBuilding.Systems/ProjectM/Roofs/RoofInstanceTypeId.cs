// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofInstanceTypeId
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoofInstanceTypeId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NorthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_SouthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_EastOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_WestOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobTypeRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoofCategoryType;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RoofInstanceTypeId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    [FieldOffset(0)]
    public PrefabGUID NorthOrnament;
    [FieldOffset(4)]
    public PrefabGUID SouthOrnament;
    [FieldOffset(8)]
    public PrefabGUID EastOrnament;
    [FieldOffset(12)]
    public PrefabGUID WestOrnament;
    [FieldOffset(16)]
    public TileBlobRootType BlobType;
    [FieldOffset(20)]
    public OrthogonalRotation BlobTypeRotation;
    [FieldOffset(24)]
    public RoofCategoryType RoofCategoryType;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1191500, RefRangeEnd = 1191501, XrefRangeStart = 1191496, XrefRangeEnd = 1191500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(RoofInstanceTypeId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofInstanceTypeId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RoofInstanceTypeId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191501, XrefRangeEnd = 1191504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofInstanceTypeId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191504, XrefRangeEnd = 1191507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofInstanceTypeId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RoofInstanceTypeId()
    {
      Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Roofs", nameof (RoofInstanceTypeId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr);
      RoofInstanceTypeId.NativeFieldInfoPtr_NorthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (NorthOrnament));
      RoofInstanceTypeId.NativeFieldInfoPtr_SouthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (SouthOrnament));
      RoofInstanceTypeId.NativeFieldInfoPtr_EastOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (EastOrnament));
      RoofInstanceTypeId.NativeFieldInfoPtr_WestOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (WestOrnament));
      RoofInstanceTypeId.NativeFieldInfoPtr_BlobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (BlobType));
      RoofInstanceTypeId.NativeFieldInfoPtr_BlobTypeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (BlobTypeRotation));
      RoofInstanceTypeId.NativeFieldInfoPtr_RoofCategoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, nameof (RoofCategoryType));
      RoofInstanceTypeId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RoofInstanceTypeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, 100663454);
      RoofInstanceTypeId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, 100663455);
      RoofInstanceTypeId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, 100663456);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofInstanceTypeId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
