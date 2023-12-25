// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.SetClientNetworkStateOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetClientNetworkStateOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsNetworkActive_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNetworkActive_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0;
    [FieldOffset(0)]
    public System.IntPtr _ClientHandle_k__BackingField;
    [FieldOffset(8)]
    public bool _IsNetworkActive_k__BackingField;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsNetworkActive
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptions.NativeMethodInfoPtr_get_IsNetworkActive_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptions.NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SetClientNetworkStateOptions()
    {
      Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (SetClientNetworkStateOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr);
      SetClientNetworkStateOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, "<ClientHandle>k__BackingField");
      SetClientNetworkStateOptions.NativeFieldInfoPtr__IsNetworkActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, "<IsNetworkActive>k__BackingField");
      SetClientNetworkStateOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, 100673898);
      SetClientNetworkStateOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, 100673899);
      SetClientNetworkStateOptions.NativeMethodInfoPtr_get_IsNetworkActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, 100673900);
      SetClientNetworkStateOptions.NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, 100673901);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetClientNetworkStateOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
