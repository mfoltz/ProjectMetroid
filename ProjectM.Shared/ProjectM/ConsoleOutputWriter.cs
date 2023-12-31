// Decompiled with JetBrains decompiler
// Type: ProjectM.ConsoleOutputWriter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ConsoleOutputWriter : Stream
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnWrite;
    private static readonly System.IntPtr NativeFieldInfoPtr__LogBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnWrite_Public_add_Void_Action_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnWrite_Public_rem_Void_Action_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732730, XrefRangeEnd = 732734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnWrite(Il2CppSystem.Action<string> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleOutputWriter.NativeMethodInfoPtr_add_OnWrite_Public_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732734, XrefRangeEnd = 732738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnWrite(Il2CppSystem.Action<string> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleOutputWriter.NativeMethodInfoPtr_remove_OnWrite_Public_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public override unsafe bool CanRead
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe bool CanSeek
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe bool CanWrite
    {
      [CallerCount(25), CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732738, XrefRangeEnd = 732750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Flush()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public override unsafe long Length
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732750, XrefRangeEnd = 732755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe long Position
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732755, XrefRangeEnd = 732760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732760, XrefRangeEnd = 732765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732765, XrefRangeEnd = 732770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int count)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732770, XrefRangeEnd = 732775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe long Seek(long offset, SeekOrigin origin)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &origin;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732775, XrefRangeEnd = 732780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SetLength(long value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732780, XrefRangeEnd = 732803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Write(Il2CppStructArray<byte> buffer, int offset, int count)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleOutputWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732803, XrefRangeEnd = 732807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConsoleOutputWriter()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleOutputWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConsoleOutputWriter()
    {
      Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConsoleOutputWriter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr);
      ConsoleOutputWriter.NativeFieldInfoPtr_OnWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, nameof (OnWrite));
      ConsoleOutputWriter.NativeFieldInfoPtr__LogBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, nameof (_LogBuffer));
      ConsoleOutputWriter.NativeMethodInfoPtr_add_OnWrite_Public_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664744);
      ConsoleOutputWriter.NativeMethodInfoPtr_remove_OnWrite_Public_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664745);
      ConsoleOutputWriter.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664746);
      ConsoleOutputWriter.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664747);
      ConsoleOutputWriter.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664748);
      ConsoleOutputWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664749);
      ConsoleOutputWriter.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664750);
      ConsoleOutputWriter.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664751);
      ConsoleOutputWriter.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664752);
      ConsoleOutputWriter.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664753);
      ConsoleOutputWriter.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664754);
      ConsoleOutputWriter.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664755);
      ConsoleOutputWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664756);
      ConsoleOutputWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleOutputWriter>.NativeClassPtr, 100664757);
    }

    public ConsoleOutputWriter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action<string> OnWrite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleOutputWriter.NativeFieldInfoPtr_OnWrite));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleOutputWriter.NativeFieldInfoPtr_OnWrite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe StringBuilder _LogBuffer
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ConsoleOutputWriter.NativeFieldInfoPtr__LogBuffer, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConsoleOutputWriter.NativeFieldInfoPtr__LogBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
