// Decompiled with JetBrains decompiler
// Type: ProjectM.RequiredComponentMetadata
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RequiredComponentMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeFullName;
    private static readonly System.IntPtr NativeFieldInfoPtr_SavedTypeIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_RequiredComponentMetadata_byref_NetBufferIn_0;
    [FieldOffset(0)]
    public FixedString512 TypeFullName;
    [FieldOffset(512)]
    public int SavedTypeIndex;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058177, RefRangeEnd = 1058178, XrefRangeStart = 1058175, XrefRangeEnd = 1058177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(ref NetBufferOut writer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref writer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RequiredComponentMetadata.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058181, RefRangeEnd = 1058182, XrefRangeStart = 1058178, XrefRangeEnd = 1058181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RequiredComponentMetadata Deserialize(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RequiredComponentMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_RequiredComponentMetadata_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RequiredComponentMetadata*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RequiredComponentMetadata()
    {
      Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RequiredComponentMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr);
      RequiredComponentMetadata.NativeFieldInfoPtr_TypeFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr, nameof (TypeFullName));
      RequiredComponentMetadata.NativeFieldInfoPtr_SavedTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr, nameof (SavedTypeIndex));
      RequiredComponentMetadata.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr, 100683073);
      RequiredComponentMetadata.NativeMethodInfoPtr_Deserialize_Public_Static_RequiredComponentMetadata_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr, 100683074);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequiredComponentMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
