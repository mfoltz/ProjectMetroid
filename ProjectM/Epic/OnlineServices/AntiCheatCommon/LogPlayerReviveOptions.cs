// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerReviveOptions
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
  public struct LogPlayerReviveOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RevivedPlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReviverPlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RevivedPlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RevivedPlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReviverPlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReviverPlayerHandle_Public_set_Void_IntPtr_0;
    [FieldOffset(0)]
    public System.IntPtr _RevivedPlayerHandle_k__BackingField;
    [FieldOffset(8)]
    public System.IntPtr _ReviverPlayerHandle_k__BackingField;

    public unsafe System.IntPtr RevivedPlayerHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptions.NativeMethodInfoPtr_get_RevivedPlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptions.NativeMethodInfoPtr_set_RevivedPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr ReviverPlayerHandle
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptions.NativeMethodInfoPtr_get_ReviverPlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptions.NativeMethodInfoPtr_set_ReviverPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LogPlayerReviveOptions()
    {
      Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerReviveOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr);
      LogPlayerReviveOptions.NativeFieldInfoPtr__RevivedPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, "<RevivedPlayerHandle>k__BackingField");
      LogPlayerReviveOptions.NativeFieldInfoPtr__ReviverPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, "<ReviverPlayerHandle>k__BackingField");
      LogPlayerReviveOptions.NativeMethodInfoPtr_get_RevivedPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, 100674022);
      LogPlayerReviveOptions.NativeMethodInfoPtr_set_RevivedPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, 100674023);
      LogPlayerReviveOptions.NativeMethodInfoPtr_get_ReviverPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, 100674024);
      LogPlayerReviveOptions.NativeMethodInfoPtr_set_ReviverPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, 100674025);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerReviveOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
