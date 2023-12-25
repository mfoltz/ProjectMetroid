// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistentBlobMetadata
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PersistentBlobMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobId;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobAssetPtr;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_PersistentBlobMetadata_byref_NetBufferIn_0;
    [FieldOffset(0)]
    public PersistentBlobMetadata.Identifier BlobId;
    [FieldOffset(24)]
    public System.IntPtr BlobAssetPtr;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058166, RefRangeEnd = 1058167, XrefRangeStart = 1058159, XrefRangeEnd = 1058166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(ref NetBufferOut writer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref writer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistentBlobMetadata.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058174, RefRangeEnd = 1058175, XrefRangeStart = 1058167, XrefRangeEnd = 1058174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistentBlobMetadata Deserialize(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistentBlobMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_PersistentBlobMetadata_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PersistentBlobMetadata*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PersistentBlobMetadata()
    {
      Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PersistentBlobMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr);
      PersistentBlobMetadata.NativeFieldInfoPtr_BlobId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr, nameof (BlobId));
      PersistentBlobMetadata.NativeFieldInfoPtr_BlobAssetPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr, nameof (BlobAssetPtr));
      PersistentBlobMetadata.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr, 100683068);
      PersistentBlobMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_PersistentBlobMetadata_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr, 100683069);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Identifier
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentStableTypeHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlobFieldOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Identifier_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public ulong ComponentStableTypeHash;
      [FieldOffset(16)]
      public int BlobFieldOffset;
      [FieldOffset(20)]
      public int ElementIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058154, XrefRangeEnd = 1058157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistentBlobMetadata.Identifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058157, XrefRangeEnd = 1058158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(PersistentBlobMetadata.Identifier other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistentBlobMetadata.Identifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Identifier_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058158, XrefRangeEnd = 1058159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistentBlobMetadata.Identifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Identifier()
      {
        Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentBlobMetadata>.NativeClassPtr, nameof (Identifier));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr);
        PersistentBlobMetadata.Identifier.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, nameof (Entity));
        PersistentBlobMetadata.Identifier.NativeFieldInfoPtr_ComponentStableTypeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, nameof (ComponentStableTypeHash));
        PersistentBlobMetadata.Identifier.NativeFieldInfoPtr_BlobFieldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, nameof (BlobFieldOffset));
        PersistentBlobMetadata.Identifier.NativeFieldInfoPtr_ElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, nameof (ElementIndex));
        PersistentBlobMetadata.Identifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, 100683070);
        PersistentBlobMetadata.Identifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Identifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, 100683071);
        PersistentBlobMetadata.Identifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, 100683072);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistentBlobMetadata.Identifier>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
