// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GraphSocketConnection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class GraphSocketConnection : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NodeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__SocketGuid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeGuid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketGuid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_GraphSocketConnection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Is_Public_Boolean_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SocketIs_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    public unsafe string NodeGuid
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_get_NodeGuid_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string SocketGuid
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_get_SocketGuid_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(86)]
    [CachedScanResults(RefRangeStart = 55800, RefRangeEnd = 55886, XrefRangeStart = 55800, XrefRangeEnd = 55886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphSocketConnection(string nodeGuid, string socketGuid)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe bool IsEmpty
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098012, XrefRangeEnd = 1098013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe GraphSocketConnection Empty
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098013, XrefRangeEnd = 1098015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_get_Empty_Public_Static_get_GraphSocketConnection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new GraphSocketConnection(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098016, RefRangeEnd = 1098017, XrefRangeStart = 1098015, XrefRangeEnd = 1098016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Is(string nodeGuid, string socketGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_Is_Public_Boolean_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098018, RefRangeEnd = 1098019, XrefRangeStart = 1098017, XrefRangeEnd = 1098018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SocketIs(string socketGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_SocketIs_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098019, XrefRangeEnd = 1098063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphSocketConnection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static GraphSocketConnection()
    {
      Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GraphSocketConnection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr);
      GraphSocketConnection.NativeFieldInfoPtr__NodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, nameof (_NodeGuid));
      GraphSocketConnection.NativeFieldInfoPtr__SocketGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, nameof (_SocketGuid));
      GraphSocketConnection.NativeMethodInfoPtr_get_NodeGuid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687150);
      GraphSocketConnection.NativeMethodInfoPtr_get_SocketGuid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687151);
      GraphSocketConnection.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687152);
      GraphSocketConnection.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687153);
      GraphSocketConnection.NativeMethodInfoPtr_get_Empty_Public_Static_get_GraphSocketConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687154);
      GraphSocketConnection.NativeMethodInfoPtr_Is_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687155);
      GraphSocketConnection.NativeMethodInfoPtr_SocketIs_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687156);
      GraphSocketConnection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, 100687157);
    }

    public GraphSocketConnection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GraphSocketConnection()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, data));
    }

    public unsafe string _NodeGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphSocketConnection.NativeFieldInfoPtr__NodeGuid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphSocketConnection.NativeFieldInfoPtr__NodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _SocketGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphSocketConnection.NativeFieldInfoPtr__SocketGuid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphSocketConnection.NativeFieldInfoPtr__SocketGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
