// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientCreateData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  public class ClientCreateData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RecordClientReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayClientReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientReplayFilePath;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuickStartup;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientCreateData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientCreateData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientCreateData()
    {
      Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClientCreateData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr);
      ClientCreateData.NativeFieldInfoPtr_RecordClientReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr, nameof (RecordClientReplay));
      ClientCreateData.NativeFieldInfoPtr_PlayClientReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr, nameof (PlayClientReplay));
      ClientCreateData.NativeFieldInfoPtr_ClientReplayFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr, nameof (ClientReplayFilePath));
      ClientCreateData.NativeFieldInfoPtr_QuickStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr, nameof (QuickStartup));
      ClientCreateData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCreateData>.NativeClassPtr, 100675556);
    }

    public ClientCreateData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool RecordClientReplay
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_RecordClientReplay));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_RecordClientReplay)) = value;
      }
    }

    public unsafe bool PlayClientReplay
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_PlayClientReplay));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_PlayClientReplay)) = value;
      }
    }

    public unsafe FixedString512 ClientReplayFilePath
    {
      get
      {
        return *(FixedString512*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_ClientReplayFilePath));
      }
      [param: In] set
      {
        *(FixedString512*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_ClientReplayFilePath)) = value;
      }
    }

    public unsafe bool QuickStartup
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_QuickStartup));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientCreateData.NativeFieldInfoPtr_QuickStartup)) = value;
      }
    }
  }
}
