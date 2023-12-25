// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistentComponentMetadata
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
  public struct PersistentComponentMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StableTypeHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_SavedTypeIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_PersistentComponentMetadata_byref_NetBufferIn_0;
    [FieldOffset(0)]
    public ulong StableTypeHash;
    [FieldOffset(8)]
    public int ComponentSize;
    [FieldOffset(12)]
    public int SavedTypeIndex;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058149, RefRangeEnd = 1058150, XrefRangeStart = 1058146, XrefRangeEnd = 1058149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(ref NetBufferOut writer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref writer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistentComponentMetadata.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058153, RefRangeEnd = 1058154, XrefRangeStart = 1058150, XrefRangeEnd = 1058153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistentComponentMetadata Deserialize(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistentComponentMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_PersistentComponentMetadata_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PersistentComponentMetadata*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PersistentComponentMetadata()
    {
      Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PersistentComponentMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr);
      PersistentComponentMetadata.NativeFieldInfoPtr_StableTypeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr, nameof (StableTypeHash));
      PersistentComponentMetadata.NativeFieldInfoPtr_ComponentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr, nameof (ComponentSize));
      PersistentComponentMetadata.NativeFieldInfoPtr_SavedTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr, nameof (SavedTypeIndex));
      PersistentComponentMetadata.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr, 100683066);
      PersistentComponentMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_PersistentComponentMetadata_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr, 100683067);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistentComponentMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
