// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.TileBlobDefinition
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileBlobDefinition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NorthEdge;
    private static readonly System.IntPtr NativeFieldInfoPtr_EastEdge;
    private static readonly System.IntPtr NativeFieldInfoPtr_SouthEdge;
    private static readonly System.IntPtr NativeFieldInfoPtr_WestEdge;
    private static readonly System.IntPtr NativeFieldInfoPtr_NorthEastCorner;
    private static readonly System.IntPtr NativeFieldInfoPtr_SouthEastCorner;
    private static readonly System.IntPtr NativeFieldInfoPtr_NorthWestCorner;
    private static readonly System.IntPtr NativeFieldInfoPtr_SouthWestCorner;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromBlobType_Public_Static_TileBlobDefinition_TileBlobType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToBlobType_Public_TileBlobType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRootType_Public_TileBlobRootType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBlobTypes_Public_Boolean_byref_TileBlobType_byref_TileBlobRootType_byref_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate90_Public_TileBlobDefinition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_TileBlobDefinition_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public bool NorthEdge;
    [FieldOffset(1)]
    public bool EastEdge;
    [FieldOffset(2)]
    public bool SouthEdge;
    [FieldOffset(3)]
    public bool WestEdge;
    [FieldOffset(4)]
    public bool NorthEastCorner;
    [FieldOffset(5)]
    public bool SouthEastCorner;
    [FieldOffset(6)]
    public bool NorthWestCorner;
    [FieldOffset(7)]
    public bool SouthWestCorner;

    [CallerCount(0)]
    public static unsafe TileBlobDefinition FromBlobType(TileBlobType blobType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &blobType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_FromBlobType_Public_Static_TileBlobDefinition_TileBlobType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobDefinition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1191513, RefRangeEnd = 1191514, XrefRangeStart = 1191513, XrefRangeEnd = 1191513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBlobType ToBlobType()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_ToBlobType_Public_TileBlobType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191514, XrefRangeEnd = 1191525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBlobRootType GetRootType()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_GetRootType_Public_TileBlobRootType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobRootType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1191526, RefRangeEnd = 1191527, XrefRangeStart = 1191525, XrefRangeEnd = 1191526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBlobTypes(
      out TileBlobType blobType,
      out TileBlobRootType rootType,
      out OrthogonalRotation rootRotationOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref blobType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rootType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rootRotationOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_TryGetBlobTypes_Public_Boolean_byref_TileBlobType_byref_TileBlobRootType_byref_OrthogonalRotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe TileBlobDefinition Rotate90()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_Rotate90_Public_TileBlobDefinition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobDefinition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1191529, RefRangeEnd = 1191530, XrefRangeStart = 1191527, XrefRangeEnd = 1191529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBlobDefinition Rotate(OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_Rotate_Public_TileBlobDefinition_OrthogonalRotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobDefinition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191530, XrefRangeEnd = 1191593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileBlobDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TileBlobDefinition()
    {
      Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Roofs", nameof (TileBlobDefinition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr);
      TileBlobDefinition.NativeFieldInfoPtr_NorthEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (NorthEdge));
      TileBlobDefinition.NativeFieldInfoPtr_EastEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (EastEdge));
      TileBlobDefinition.NativeFieldInfoPtr_SouthEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (SouthEdge));
      TileBlobDefinition.NativeFieldInfoPtr_WestEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (WestEdge));
      TileBlobDefinition.NativeFieldInfoPtr_NorthEastCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (NorthEastCorner));
      TileBlobDefinition.NativeFieldInfoPtr_SouthEastCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (SouthEastCorner));
      TileBlobDefinition.NativeFieldInfoPtr_NorthWestCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (NorthWestCorner));
      TileBlobDefinition.NativeFieldInfoPtr_SouthWestCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, nameof (SouthWestCorner));
      TileBlobDefinition.NativeMethodInfoPtr_FromBlobType_Public_Static_TileBlobDefinition_TileBlobType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663459);
      TileBlobDefinition.NativeMethodInfoPtr_ToBlobType_Public_TileBlobType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663460);
      TileBlobDefinition.NativeMethodInfoPtr_GetRootType_Public_TileBlobRootType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663461);
      TileBlobDefinition.NativeMethodInfoPtr_TryGetBlobTypes_Public_Boolean_byref_TileBlobType_byref_TileBlobRootType_byref_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663462);
      TileBlobDefinition.NativeMethodInfoPtr_Rotate90_Public_TileBlobDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663463);
      TileBlobDefinition.NativeMethodInfoPtr_Rotate_Public_TileBlobDefinition_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663464);
      TileBlobDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, 100663465);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileBlobDefinition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
