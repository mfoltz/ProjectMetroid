// Decompiled with JetBrains decompiler
// Type: ProjectM.FloatModificationBuffer
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
  public struct FloatModificationBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModData_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Single_0;
    [FieldOffset(0)]
    public ModificationData<float> _ModData_k__BackingField;

    public virtual unsafe ModificationData<float> ModData
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationData<float>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FloatModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static FloatModificationBuffer()
    {
      Il2CppClassPointerStore<FloatModificationBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FloatModificationBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatModificationBuffer>.NativeClassPtr);
      FloatModificationBuffer.NativeFieldInfoPtr__ModData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatModificationBuffer>.NativeClassPtr, "<ModData>k__BackingField");
      FloatModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatModificationBuffer>.NativeClassPtr, 100665571);
      FloatModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatModificationBuffer>.NativeClassPtr, 100665572);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatModificationBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
