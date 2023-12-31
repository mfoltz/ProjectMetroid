// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PriorityEntitiesToSerializeBuffer
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
  public struct PriorityEntitiesToSerializeBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotPtr;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedPtr;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachedParentIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachedDepth;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanTimeout;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PriorityEntitiesToSerializeBuffer_0;
    [FieldOffset(0)]
    public System.IntPtr SnapshotPtr;
    [FieldOffset(8)]
    public System.IntPtr FrameChangedPtr;
    [FieldOffset(16)]
    public NetworkId NetworkId;
    [FieldOffset(24)]
    public float Priority;
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
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785487, XrefRangeEnd = 785489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(PriorityEntitiesToSerializeBuffer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PriorityEntitiesToSerializeBuffer.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PriorityEntitiesToSerializeBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PriorityEntitiesToSerializeBuffer()
    {
      Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (PriorityEntitiesToSerializeBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr);
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_SnapshotPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (SnapshotPtr));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_FrameChangedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (FrameChangedPtr));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (NetworkId));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (Priority));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_AttachedParentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (AttachedParentIndex));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_AttachedDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (AttachedDepth));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_SyncRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (SyncRate));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_HasChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (HasChanges));
      PriorityEntitiesToSerializeBuffer.NativeFieldInfoPtr_CanTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, nameof (CanTimeout));
      PriorityEntitiesToSerializeBuffer.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PriorityEntitiesToSerializeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, 100669226);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PriorityEntitiesToSerializeBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
