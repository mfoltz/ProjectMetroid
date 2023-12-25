// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.SetClientDetailsOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetClientDetailsOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientFlags_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientInputMethod_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientFlags_Public_get_AntiCheatCommonClientFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientInputMethod_Public_get_AntiCheatCommonClientInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0;
    [FieldOffset(0)]
    public System.IntPtr _ClientHandle_k__BackingField;
    [FieldOffset(8)]
    public AntiCheatCommonClientFlags _ClientFlags_k__BackingField;
    [FieldOffset(12)]
    public AntiCheatCommonClientInput _ClientInputMethod_k__BackingField;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientFlags ClientFlags
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientFlags_Public_get_AntiCheatCommonClientFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonClientFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientInput ClientInputMethod
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientInputMethod_Public_get_AntiCheatCommonClientInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonClientInput*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 204792, RefRangeEnd = 204801, XrefRangeStart = 204792, XrefRangeEnd = 204801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SetClientDetailsOptions()
    {
      Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (SetClientDetailsOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr);
      SetClientDetailsOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, "<ClientHandle>k__BackingField");
      SetClientDetailsOptions.NativeFieldInfoPtr__ClientFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, "<ClientFlags>k__BackingField");
      SetClientDetailsOptions.NativeFieldInfoPtr__ClientInputMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, "<ClientInputMethod>k__BackingField");
      SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100674285);
      SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100674286);
      SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientFlags_Public_get_AntiCheatCommonClientFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100674287);
      SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100674288);
      SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientInputMethod_Public_get_AntiCheatCommonClientInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100674289);
      SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100674290);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
