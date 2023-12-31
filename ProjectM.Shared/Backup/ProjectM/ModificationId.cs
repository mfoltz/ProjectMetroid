// Decompiled with JetBrains decompiler
// Type: ProjectM.ModificationId
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
  public struct ModificationId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewId_Public_Static_ModificationId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;
    [FieldOffset(0)]
    public readonly int Id;

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationId NewId(int id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationId.NativeMethodInfoPtr_NewId_Public_Static_ModificationId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    public static unsafe ModificationId Empty
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationId.NativeMethodInfoPtr_get_Empty_Public_Static_get_ModificationId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModificationId(int id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationId.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(129)]
    [CachedScanResults(RefRangeStart = 298273, RefRangeEnd = 298402, XrefRangeStart = 298273, XrefRangeEnd = 298402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEmpty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationId.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModificationId()
    {
      Il2CppClassPointerStore<ModificationId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModificationId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModificationId>.NativeClassPtr);
      ModificationId.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationId>.NativeClassPtr, nameof (Id));
      ModificationId.NativeMethodInfoPtr_NewId_Public_Static_ModificationId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationId>.NativeClassPtr, 100665707);
      ModificationId.NativeMethodInfoPtr_get_Empty_Public_Static_get_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationId>.NativeClassPtr, 100665708);
      ModificationId.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationId>.NativeClassPtr, 100665709);
      ModificationId.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationId>.NativeClassPtr, 100665710);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModificationId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
