// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PanicEntitiesToSerializeBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PanicEntitiesToSerializeBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotPtr;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedPtr;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Panic;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachedParentIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachedDepth;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanTimeout;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PanicEntitiesToSerializeBuffer_0;
    [FieldOffset(0)]
    public System.IntPtr SnapshotPtr;
    [FieldOffset(8)]
    public System.IntPtr FrameChangedPtr;
    [FieldOffset(16)]
    public NetworkId NetworkId;
    [FieldOffset(24)]
    public float Panic;
    [FieldOffset(28)]
    public int AttachedParentIndex;
    [FieldOffset(32)]
    public int AttachedDepth;
    [FieldOffset(36)]
    public float SyncRate;
    [FieldOffset(40)]
    public bool HasChanges;
    [FieldOffset(41)]
    public bool CanTimeout;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(PanicEntitiesToSerializeBuffer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PanicEntitiesToSerializeBuffer.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PanicEntitiesToSerializeBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PanicEntitiesToSerializeBuffer()
    {
      Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (PanicEntitiesToSerializeBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr);
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_SnapshotPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (SnapshotPtr));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_FrameChangedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (FrameChangedPtr));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (NetworkId));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_Panic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (Panic));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_AttachedParentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (AttachedParentIndex));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_AttachedDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (AttachedDepth));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_SyncRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (SyncRate));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_HasChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (HasChanges));
      PanicEntitiesToSerializeBuffer.NativeFieldInfoPtr_CanTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, nameof (CanTimeout));
      PanicEntitiesToSerializeBuffer.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PanicEntitiesToSerializeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, 100669227);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PanicEntitiesToSerializeBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
