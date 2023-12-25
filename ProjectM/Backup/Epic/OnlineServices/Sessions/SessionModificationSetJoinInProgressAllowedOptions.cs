// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionModificationSetJoinInProgressAllowedOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SessionModificationSetJoinInProgressAllowedOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AllowJoinInProgress_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0;
    [FieldOffset(0)]
    public bool _AllowJoinInProgress_k__BackingField;

    public unsafe bool AllowJoinInProgress
    {
      [CallerCount(83), CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModificationSetJoinInProgressAllowedOptions.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 246533, RefRangeEnd = 246534, XrefRangeStart = 246533, XrefRangeEnd = 246534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionModificationSetJoinInProgressAllowedOptions.NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SessionModificationSetJoinInProgressAllowedOptions()
    {
      Il2CppClassPointerStore<SessionModificationSetJoinInProgressAllowedOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionModificationSetJoinInProgressAllowedOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionModificationSetJoinInProgressAllowedOptions>.NativeClassPtr);
      SessionModificationSetJoinInProgressAllowedOptions.NativeFieldInfoPtr__AllowJoinInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationSetJoinInProgressAllowedOptions>.NativeClassPtr, "<AllowJoinInProgress>k__BackingField");
      SessionModificationSetJoinInProgressAllowedOptions.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationSetJoinInProgressAllowedOptions>.NativeClassPtr, 100666507);
      SessionModificationSetJoinInProgressAllowedOptions.NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationSetJoinInProgressAllowedOptions>.NativeClassPtr, 100666508);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionModificationSetJoinInProgressAllowedOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
