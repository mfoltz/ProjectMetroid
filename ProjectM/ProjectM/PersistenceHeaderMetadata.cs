// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistenceHeaderMetadata
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PersistenceHeaderMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SerializationFormatVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_PersistenceVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_ApplicationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabConversionMethod;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_DeserializationResult_byref_NetBufferIn_byref_PersistenceHeaderMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_PersistenceHeaderMetadata_0;
    [FieldOffset(0)]
    public int SerializationFormatVersion;
    [FieldOffset(4)]
    public PersistenceVersion PersistenceVersion;
    [FieldOffset(8)]
    public GameVersion GameVersion;
    [FieldOffset(24)]
    public ApplicationType ApplicationType;
    [FieldOffset(28)]
    public PrefabConversionMethod PrefabConversionMethod;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058191, RefRangeEnd = 1058192, XrefRangeStart = 1058182, XrefRangeEnd = 1058191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceHeaderMetadata.DeserializationResult Deserialize(
      ref NetBufferIn headerBuffer,
      out PersistenceHeaderMetadata data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref headerBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceHeaderMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_DeserializationResult_byref_NetBufferIn_byref_PersistenceHeaderMetadata_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PersistenceHeaderMetadata.DeserializationResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058201, RefRangeEnd = 1058202, XrefRangeStart = 1058192, XrefRangeEnd = 1058201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(
      ref NetBufferOut netBuffer,
      [In] ref PersistenceHeaderMetadata data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceHeaderMetadata.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_PersistenceHeaderMetadata_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PersistenceHeaderMetadata()
    {
      Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PersistenceHeaderMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr);
      PersistenceHeaderMetadata.NativeFieldInfoPtr_SerializationFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, nameof (SerializationFormatVersion));
      PersistenceHeaderMetadata.NativeFieldInfoPtr_PersistenceVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, nameof (PersistenceVersion));
      PersistenceHeaderMetadata.NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, nameof (GameVersion));
      PersistenceHeaderMetadata.NativeFieldInfoPtr_ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, nameof (ApplicationType));
      PersistenceHeaderMetadata.NativeFieldInfoPtr_PrefabConversionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, nameof (PrefabConversionMethod));
      PersistenceHeaderMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_DeserializationResult_byref_NetBufferIn_byref_PersistenceHeaderMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, 100683075);
      PersistenceHeaderMetadata.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_PersistenceHeaderMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, 100683076);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceHeaderMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum DeserializationResult
    {
      Success,
      MismatchingSerializationFormatVersion,
    }
  }
}
