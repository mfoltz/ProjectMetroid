// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.AcknowledgeEventIdOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AcknowledgeEventIdOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UiEventId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Result_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UiEventId_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Result_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Result_Public_set_Void_Result_0;
    [FieldOffset(0)]
    public ulong _UiEventId_k__BackingField;
    [FieldOffset(8)]
    public Result _Result_k__BackingField;

    public unsafe ulong UiEventId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptions.NativeMethodInfoPtr_get_UiEventId_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptions.NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Result Result
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptions.NativeMethodInfoPtr_get_Result_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptions.NativeMethodInfoPtr_set_Result_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static AcknowledgeEventIdOptions()
    {
      Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (AcknowledgeEventIdOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr);
      AcknowledgeEventIdOptions.NativeFieldInfoPtr__UiEventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, "<UiEventId>k__BackingField");
      AcknowledgeEventIdOptions.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, "<Result>k__BackingField");
      AcknowledgeEventIdOptions.NativeMethodInfoPtr_get_UiEventId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, 100665130);
      AcknowledgeEventIdOptions.NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, 100665131);
      AcknowledgeEventIdOptions.NativeMethodInfoPtr_get_Result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, 100665132);
      AcknowledgeEventIdOptions.NativeMethodInfoPtr_set_Result_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, 100665133);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AcknowledgeEventIdOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
