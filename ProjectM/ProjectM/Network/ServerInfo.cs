// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ServerInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Net;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public sealed class ServerInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IPEndPoint;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_Int32_byref_ServerInfo_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1147858, RefRangeEnd = 1147864, XrefRangeStart = 1147853, XrefRangeEnd = 1147858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryCreate(string ip, int port, out ServerInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerInfo.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_Int32_byref_ServerInfo_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerInfo local = ref output;
      System.IntPtr pointer = zero;
      ServerInfo serverInfo = pointer == System.IntPtr.Zero ? (ServerInfo) null : new ServerInfo(pointer);
      local = serverInfo;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static ServerInfo()
    {
      Il2CppClassPointerStore<ServerInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ServerInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr);
      ServerInfo.NativeFieldInfoPtr_IPEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, nameof (IPEndPoint));
      ServerInfo.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_Int32_byref_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, 100691189);
    }

    public ServerInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ServerInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, data));
    }

    public unsafe IPEndPoint IPEndPoint
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr_IPEndPoint));
        return pointer == System.IntPtr.Zero ? (IPEndPoint) null : new IPEndPoint(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfo.NativeFieldInfoPtr_IPEndPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
