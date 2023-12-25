// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.ReceiveMessageFromServerOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient
{
  public sealed class ReceiveMessageFromServerOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0;

    public unsafe Il2CppSystem.ArraySegment<byte> Data
    {
      [CallerCount(46), CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromServerOptions.NativeMethodInfoPtr_get_Data_Public_get_ArraySegment_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.ArraySegment<byte>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromServerOptions.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static ReceiveMessageFromServerOptions()
    {
      Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (ReceiveMessageFromServerOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr);
      ReceiveMessageFromServerOptions.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr, "<Data>k__BackingField");
      ReceiveMessageFromServerOptions.NativeMethodInfoPtr_get_Data_Public_get_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr, 100674485);
      ReceiveMessageFromServerOptions.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr, 100674486);
    }

    public ReceiveMessageFromServerOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ReceiveMessageFromServerOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceiveMessageFromServerOptions>.NativeClassPtr, data));
    }

    public Il2CppSystem.ArraySegment<byte> _Data_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceiveMessageFromServerOptions.NativeFieldInfoPtr__Data_k__BackingField);
        return new Il2CppSystem.ArraySegment<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ArraySegment<byte>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceiveMessageFromServerOptions.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ArraySegment<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
