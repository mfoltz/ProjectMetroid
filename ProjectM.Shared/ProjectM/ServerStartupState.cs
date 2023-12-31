// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerStartupState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerStartupState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadPersistentObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitializeSerializePersistence;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CombinedState_Public_get_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SuccessfulStartup_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0;
    [FieldOffset(0)]
    public ServerStartupState.State LoadPersistentObjects;
    [FieldOffset(4)]
    public ServerStartupState.State InitializeSerializePersistence;

    public unsafe ServerStartupState.State CombinedState
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerStartupState.NativeMethodInfoPtr_get_CombinedState_Public_get_State_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ServerStartupState.State*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool SuccessfulStartup
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 735828, RefRangeEnd = 735833, XrefRangeStart = 735828, XrefRangeEnd = 735828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerStartupState.NativeMethodInfoPtr_get_SuccessfulStartup_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool Failed
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 735833, RefRangeEnd = 735835, XrefRangeStart = 735833, XrefRangeEnd = 735833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerStartupState.NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ServerStartupState()
    {
      Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerStartupState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr);
      ServerStartupState.NativeFieldInfoPtr_LoadPersistentObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr, nameof (LoadPersistentObjects));
      ServerStartupState.NativeFieldInfoPtr_InitializeSerializePersistence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr, nameof (InitializeSerializePersistence));
      ServerStartupState.NativeMethodInfoPtr_get_CombinedState_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr, 100664968);
      ServerStartupState.NativeMethodInfoPtr_get_SuccessfulStartup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr, 100664969);
      ServerStartupState.NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr, 100664970);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerStartupState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum State
    {
      None = 0,
      Waiting = 1,
      Initializing = 2,
      SuccessfulStartup = 4,
      Failed = 8,
    }
  }
}
