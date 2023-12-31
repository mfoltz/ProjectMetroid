// Decompiled with JetBrains decompiler
// Type: ProjectM.BoolModificationBuffer
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
  public struct BoolModificationBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModData_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Boolean_0;
    [FieldOffset(0)]
    public ModificationData<bool> _ModData_k__BackingField;

    public virtual unsafe ModificationData<bool> ModData
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 242918, RefRangeEnd = 242920, XrefRangeStart = 242918, XrefRangeEnd = 242920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoolModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationData<bool>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(5), CachedScanResults(RefRangeStart = 743279, RefRangeEnd = 743284, XrefRangeStart = 743279, XrefRangeEnd = 743279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BoolModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static BoolModificationBuffer()
    {
      Il2CppClassPointerStore<BoolModificationBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BoolModificationBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolModificationBuffer>.NativeClassPtr);
      BoolModificationBuffer.NativeFieldInfoPtr__ModData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolModificationBuffer>.NativeClassPtr, "<ModData>k__BackingField");
      BoolModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolModificationBuffer>.NativeClassPtr, 100665520);
      BoolModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolModificationBuffer>.NativeClassPtr, 100665521);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoolModificationBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
