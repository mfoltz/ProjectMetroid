// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleRaidData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRaidData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_ICastleLevelData_get_Level_Private_Virtual_Final_New_get_Int32_0;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID Guid;
    [FieldOffset(12)]
    public int Level;

    public virtual unsafe int ProjectM\u002EICastleLevelData\u002ELevel
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRaidData.NativeMethodInfoPtr_ProjectM_ICastleLevelData_get_Level_Private_Virtual_Final_New_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static CastleRaidData()
    {
      Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastleRaidData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr);
      CastleRaidData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr, nameof (Entity));
      CastleRaidData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr, nameof (Guid));
      CastleRaidData.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr, nameof (Level));
      CastleRaidData.NativeMethodInfoPtr_ProjectM_ICastleLevelData_get_Level_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr, 100663995);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRaidData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
