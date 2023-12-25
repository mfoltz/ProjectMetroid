// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SocketNamesAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SocketNamesAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SocketNames;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketNames_Public_get_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSocketName_Public_String_Int32_0;

    public unsafe List<string> SocketNames
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SocketNamesAttribute.NativeMethodInfoPtr_get_SocketNames_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1098134, RefRangeEnd = 1098136, XrefRangeStart = 1098126, XrefRangeEnd = 1098134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SocketNamesAttribute([Optional] Il2CppStringArray socketNames)
    {
      if (socketNames == null)
        socketNames = new Il2CppStringArray(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socketNames);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocketNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098136, XrefRangeEnd = 1098140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetSocketName(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SocketNamesAttribute.NativeMethodInfoPtr_GetSocketName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    public SocketNamesAttribute(params string[] socketNames)
      : this(new Il2CppStringArray(socketNames))
    {
    }

    static SocketNamesAttribute()
    {
      Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SocketNamesAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr);
      SocketNamesAttribute.NativeFieldInfoPtr__SocketNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr, nameof (_SocketNames));
      SocketNamesAttribute.NativeMethodInfoPtr_get_SocketNames_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr, 100687200);
      SocketNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr, 100687201);
      SocketNamesAttribute.NativeMethodInfoPtr_GetSocketName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketNamesAttribute>.NativeClassPtr, 100687202);
    }

    public SocketNamesAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<string> _SocketNames
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocketNamesAttribute.NativeFieldInfoPtr__SocketNames));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocketNamesAttribute.NativeFieldInfoPtr__SocketNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
