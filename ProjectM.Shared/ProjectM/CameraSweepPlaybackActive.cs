// Decompiled with JetBrains decompiler
// Type: ProjectM.CameraSweepPlaybackActive
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CameraSweepPlaybackActive
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrameData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedOnPlaybackStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoopPlayback;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncToReplay;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryWriter_CameraSweepPlaybackActive_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_CameraSweepPlaybackActive_BinaryReader_0;
    [FieldOffset(0)]
    public RecordedCameraFrame CurrentFrameData;
    [FieldOffset(48)]
    public double ElapsedOnPlaybackStart;
    [FieldOffset(56)]
    public bool LoopPlayback;
    [FieldOffset(57)]
    public bool SyncToReplay;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722577, XrefRangeEnd = 722578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(BinaryWriter writer, CameraSweepPlaybackActive data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CameraSweepPlaybackActive.NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryWriter_CameraSweepPlaybackActive_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722578, XrefRangeEnd = 722579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CameraSweepPlaybackActive Deserialize(BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraSweepPlaybackActive.NativeMethodInfoPtr_Deserialize_Public_Static_CameraSweepPlaybackActive_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CameraSweepPlaybackActive*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CameraSweepPlaybackActive()
    {
      Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CameraSweepPlaybackActive));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr);
      CameraSweepPlaybackActive.NativeFieldInfoPtr_CurrentFrameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, nameof (CurrentFrameData));
      CameraSweepPlaybackActive.NativeFieldInfoPtr_ElapsedOnPlaybackStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, nameof (ElapsedOnPlaybackStart));
      CameraSweepPlaybackActive.NativeFieldInfoPtr_LoopPlayback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, nameof (LoopPlayback));
      CameraSweepPlaybackActive.NativeFieldInfoPtr_SyncToReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, nameof (SyncToReplay));
      CameraSweepPlaybackActive.NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryWriter_CameraSweepPlaybackActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, 100663805);
      CameraSweepPlaybackActive.NativeMethodInfoPtr_Deserialize_Public_Static_CameraSweepPlaybackActive_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, 100663806);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraSweepPlaybackActive>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
