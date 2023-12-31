// Decompiled with JetBrains decompiler
// Type: ProjectM.SystemGuidWrapper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SystemGuidWrapper
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__a;
    private static readonly System.IntPtr NativeFieldInfoPtr__b;
    private static readonly System.IntPtr NativeFieldInfoPtr__c;
    private static readonly System.IntPtr NativeFieldInfoPtr__d;
    private static readonly System.IntPtr NativeFieldInfoPtr__e;
    private static readonly System.IntPtr NativeFieldInfoPtr__f;
    private static readonly System.IntPtr NativeFieldInfoPtr__g;
    private static readonly System.IntPtr NativeFieldInfoPtr__h;
    private static readonly System.IntPtr NativeFieldInfoPtr__i;
    private static readonly System.IntPtr NativeFieldInfoPtr__j;
    private static readonly System.IntPtr NativeFieldInfoPtr__k;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_get_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_a_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_b_Public_get_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_c_Public_get_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_d_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_e_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_f_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_g_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_h_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_i_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_j_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_k_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromBytes_Public_Static_SystemGuidWrapper_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0;
    [FieldOffset(0)]
    public Il2CppSystem.Guid _Guid;
    [FieldOffset(0)]
    public int _a;
    [FieldOffset(4)]
    public short _b;
    [FieldOffset(6)]
    public short _c;
    [FieldOffset(8)]
    public byte _d;
    [FieldOffset(9)]
    public byte _e;
    [FieldOffset(10)]
    public byte _f;
    [FieldOffset(11)]
    public byte _g;
    [FieldOffset(12)]
    public byte _h;
    [FieldOffset(13)]
    public byte _i;
    [FieldOffset(14)]
    public byte _j;
    [FieldOffset(15)]
    public byte _k;

    public unsafe Il2CppSystem.Guid Guid
    {
      [CallerCount(46), CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_Guid_Public_get_Guid_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Il2CppSystem.Guid*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int a
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_a_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe short b
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_b_Public_get_Int16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(short*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe short c
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_c_Public_get_Int16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(short*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte d
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_d_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte e
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_e_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte f
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_f_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte g
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_g_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte h
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_h_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte i
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_i_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte j
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_j_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte k
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_k_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SystemGuidWrapper(Il2CppSystem.Guid guid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &guid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe byte this[int index]
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 765277, RefRangeEnd = 765278, XrefRangeStart = 765277, XrefRangeEnd = 765277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765278, XrefRangeEnd = 765279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SystemGuidWrapper FromBytes(
      byte b1,
      byte b2,
      byte b3,
      byte b4,
      byte b5,
      byte b6,
      byte b7,
      byte b8,
      byte b9,
      byte b10,
      byte b11,
      byte b12,
      byte b13,
      byte b14,
      byte b15,
      byte b16)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[16];
      numPtr[0] = (System.IntPtr) &b1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &b4;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &b5;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &b6;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &b7;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &b8;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &b9;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &b10;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &b11;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &b12;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &b13;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &b14;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = (System.IntPtr) &b15;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &b16;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemGuidWrapper.NativeMethodInfoPtr_FromBytes_Public_Static_SystemGuidWrapper_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SystemGuidWrapper*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SystemGuidWrapper()
    {
      Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SystemGuidWrapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr);
      SystemGuidWrapper.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_Guid));
      SystemGuidWrapper.NativeFieldInfoPtr__a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_a));
      SystemGuidWrapper.NativeFieldInfoPtr__b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_b));
      SystemGuidWrapper.NativeFieldInfoPtr__c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_c));
      SystemGuidWrapper.NativeFieldInfoPtr__d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_d));
      SystemGuidWrapper.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_e));
      SystemGuidWrapper.NativeFieldInfoPtr__f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_f));
      SystemGuidWrapper.NativeFieldInfoPtr__g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_g));
      SystemGuidWrapper.NativeFieldInfoPtr__h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_h));
      SystemGuidWrapper.NativeFieldInfoPtr__i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_i));
      SystemGuidWrapper.NativeFieldInfoPtr__j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_j));
      SystemGuidWrapper.NativeFieldInfoPtr__k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, nameof (_k));
      SystemGuidWrapper.NativeMethodInfoPtr_get_Guid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667593);
      SystemGuidWrapper.NativeMethodInfoPtr_get_a_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667594);
      SystemGuidWrapper.NativeMethodInfoPtr_get_b_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667595);
      SystemGuidWrapper.NativeMethodInfoPtr_get_c_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667596);
      SystemGuidWrapper.NativeMethodInfoPtr_get_d_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667597);
      SystemGuidWrapper.NativeMethodInfoPtr_get_e_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667598);
      SystemGuidWrapper.NativeMethodInfoPtr_get_f_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667599);
      SystemGuidWrapper.NativeMethodInfoPtr_get_g_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667600);
      SystemGuidWrapper.NativeMethodInfoPtr_get_h_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667601);
      SystemGuidWrapper.NativeMethodInfoPtr_get_i_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667602);
      SystemGuidWrapper.NativeMethodInfoPtr_get_j_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667603);
      SystemGuidWrapper.NativeMethodInfoPtr_get_k_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667604);
      SystemGuidWrapper.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667605);
      SystemGuidWrapper.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667606);
      SystemGuidWrapper.NativeMethodInfoPtr_FromBytes_Public_Static_SystemGuidWrapper_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, 100667607);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SystemGuidWrapper>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
