// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPortRangeOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetPortRangeOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Port_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxAdditionalPortsToTry_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Port_Public_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxAdditionalPortsToTry_Public_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0;
    [FieldOffset(0)]
    public ushort _Port_k__BackingField;
    [FieldOffset(2)]
    public ushort _MaxAdditionalPortsToTry_k__BackingField;

    public unsafe ushort Port
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 261277, RefRangeEnd = 261288, XrefRangeStart = 261277, XrefRangeEnd = 261288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 184798, RefRangeEnd = 184809, XrefRangeStart = 184798, XrefRangeEnd = 184809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ushort MaxAdditionalPortsToTry
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_get_MaxAdditionalPortsToTry_Public_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SetPortRangeOptions()
    {
      Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SetPortRangeOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr);
      SetPortRangeOptions.NativeFieldInfoPtr__Port_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, "<Port>k__BackingField");
      SetPortRangeOptions.NativeFieldInfoPtr__MaxAdditionalPortsToTry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, "<MaxAdditionalPortsToTry>k__BackingField");
      SetPortRangeOptions.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100669245);
      SetPortRangeOptions.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100669246);
      SetPortRangeOptions.NativeMethodInfoPtr_get_MaxAdditionalPortsToTry_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100669247);
      SetPortRangeOptions.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100669248);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
