// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.HttpService.MessageResponse
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network.HttpService
{
  public class MessageResponse : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_result;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MessageResponse()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageResponse>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MessageResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MessageResponse()
    {
      Il2CppClassPointerStore<MessageResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network.HttpService", nameof (MessageResponse));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageResponse>.NativeClassPtr);
      MessageResponse.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageResponse>.NativeClassPtr, nameof (result));
      MessageResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageResponse>.NativeClassPtr, 100691898);
    }

    public MessageResponse(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool result
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MessageResponse.NativeFieldInfoPtr_result));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MessageResponse.NativeFieldInfoPtr_result)) = value;
      }
    }
  }
}
