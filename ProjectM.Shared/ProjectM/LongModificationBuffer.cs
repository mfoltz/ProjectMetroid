// Decompiled with JetBrains decompiler
// Type: ProjectM.LongModificationBuffer
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
  public struct LongModificationBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModData_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Int64_0;
    [FieldOffset(0)]
    public ModificationData<long> _ModData_k__BackingField;

    public virtual unsafe ModificationData<long> ModData
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 254293, RefRangeEnd = 254299, XrefRangeStart = 254293, XrefRangeEnd = 254299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LongModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationData<long>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(12), CachedScanResults(RefRangeStart = 254299, RefRangeEnd = 254311, XrefRangeStart = 254299, XrefRangeEnd = 254311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LongModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LongModificationBuffer()
    {
      Il2CppClassPointerStore<LongModificationBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LongModificationBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongModificationBuffer>.NativeClassPtr);
      LongModificationBuffer.NativeFieldInfoPtr__ModData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongModificationBuffer>.NativeClassPtr, "<ModData>k__BackingField");
      LongModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongModificationBuffer>.NativeClassPtr, 100665639);
      LongModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongModificationBuffer>.NativeClassPtr, 100665640);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LongModificationBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
