// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ServerLoadProgress
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerLoadProgress
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NumOfLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumOfRequested;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLoadingGameData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_ServerLoadProgress_0;
    [FieldOffset(0)]
    public ushort NumOfLoaded;
    [FieldOffset(2)]
    public ushort NumOfRequested;
    [FieldOffset(4)]
    public bool IsLoadingGameData;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1148034, RefRangeEnd = 1148035, XrefRangeStart = 1148031, XrefRangeEnd = 1148034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(ref NetBufferOut netBufferOut)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBufferOut;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerLoadProgress.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1148038, RefRangeEnd = 1148039, XrefRangeStart = 1148035, XrefRangeEnd = 1148038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Deserialize(
      ref NetBufferIn netBufferIn,
      out ServerLoadProgress serverLoadProgress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBufferIn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverLoadProgress;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerLoadProgress.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_ServerLoadProgress_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerLoadProgress()
    {
      Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ServerLoadProgress));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr);
      ServerLoadProgress.NativeFieldInfoPtr_NumOfLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr, nameof (NumOfLoaded));
      ServerLoadProgress.NativeFieldInfoPtr_NumOfRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr, nameof (NumOfRequested));
      ServerLoadProgress.NativeFieldInfoPtr_IsLoadingGameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr, nameof (IsLoadingGameData));
      ServerLoadProgress.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr, 100691199);
      ServerLoadProgress.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_ServerLoadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr, 100691200);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerLoadProgress>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
