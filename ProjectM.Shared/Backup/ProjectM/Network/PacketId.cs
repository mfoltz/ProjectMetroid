// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PacketId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PacketId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
    [FieldOffset(0)]
    public readonly int UserIndex;
    [FieldOffset(4)]
    public readonly int ServerFrame;

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PacketId(int userIndex, int frame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &frame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketId.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PacketId()
    {
      Il2CppClassPointerStore<PacketId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (PacketId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketId>.NativeClassPtr);
      PacketId.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketId>.NativeClassPtr, nameof (UserIndex));
      PacketId.NativeFieldInfoPtr_ServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketId>.NativeClassPtr, nameof (ServerFrame));
      PacketId.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketId>.NativeClassPtr, 100669193);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
